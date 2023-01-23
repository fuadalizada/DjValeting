using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
