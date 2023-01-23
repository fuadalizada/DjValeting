using DjValeting.DAL.ViewModels;
using DjValeting.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DjValeting.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
           

            return View(model);
        }
    }
}
