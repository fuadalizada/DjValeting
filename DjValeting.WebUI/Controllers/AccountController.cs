using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticateService _authenticateService;
        public AccountController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _authenticateService.Authenticate(model);
            if (result.Response && result.RoleName is "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (result.Response && result.RoleName is "User")
            {
                return RedirectToAction("Index", "User");
            }
            ViewBag.ErrorMessage = "Email or password is incorrect.Please try again.";
            return View(model);
        }
    }
}
