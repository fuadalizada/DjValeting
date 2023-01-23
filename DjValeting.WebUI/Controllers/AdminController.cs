using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
