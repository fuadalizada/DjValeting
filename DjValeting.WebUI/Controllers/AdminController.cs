using DjValeting.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookingFormService _brakingFormService;
        public AdminController(IBookingFormService bokkingFormService)
        {
            _brakingFormService= bokkingFormService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _brakingFormService.GetAllAsync();
            return View(result);
        }
    }
}
