using DjValeting.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookingFormService _bookingFormService;

        public AdminController(IBookingFormService bookingFormService)
        {
            _bookingFormService= bookingFormService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _bookingFormService.GetAllAsync();
            return View(result);
        }

        [HttpDelete]
        public async Task<bool> DeleteForm(string id)
        {
            var guid = new Guid(id);
            var result = await _bookingFormService.DeleteAsync(guid);
            return result;
        }

        [HttpPatch]
        public async Task<bool> ApproveForm(string id)
        {
            var guid = new Guid(id);
            var result = await _bookingFormService.ApproveForm(guid);
            return result;
        }
    }
}
