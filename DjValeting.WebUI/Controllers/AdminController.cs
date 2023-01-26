using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.WebUI.Helpers;
using DjValeting.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DjValeting.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookingFormService _bookingFormService;
        private readonly IFlexibilityService _flexibilityService;
        private readonly IVehicleSizeService _vehicleSizeService;
        private readonly SomeActionsAfterApprovingForm _someActionsAfterApprovingForm;

        public AdminController(IBookingFormService bookingFormService, IFlexibilityService flexibilityService, IVehicleSizeService vehicleSizeService, SomeActionsAfterApprovingForm someActionsAfterApprovingForm)
        {
            _bookingFormService = bookingFormService;
            _flexibilityService = flexibilityService;
            _vehicleSizeService = vehicleSizeService;
            _someActionsAfterApprovingForm = someActionsAfterApprovingForm;
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
            if (result)
            {
                var clientEmail = await _bookingFormService.GetClientEmail(guid);
                _someActionsAfterApprovingForm.FormApproved += _someActionsAfterApprovingForm.SendEmail;
                _someActionsAfterApprovingForm.OnSendMailAfterApprovingForm(clientEmail);
            }
            return result;
        }        

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var guid = new Guid(id);
            var result = await _bookingFormService.FindByIdAsync(guid);

            var flexibilityList = await _flexibilityService.GetAllAsync();
            var vehicleSizeList = await _vehicleSizeService.GetAllAsync();
            ViewBag.FlexibilityList = flexibilityList;
            ViewBag.VehicleSizeList = vehicleSizeList;

            return View(result);
        }

        [HttpPut]
        public async Task<bool> Update(BookingFormViewModel bookingFormViewModel)
        {
            BookingFormDto bookingFormDto = new()
            {
                Id = bookingFormViewModel.Id,
                Name = bookingFormViewModel.Name,
                Email = bookingFormViewModel.Email,
                FlexibilityId = bookingFormViewModel.FlexibilityId,
                VehicleSizeId = bookingFormViewModel.VehicleSizeId,
                ContactNumber = bookingFormViewModel.ContactNumber,
                IsActive = false,
                CreateDate = Convert.ToDateTime(bookingFormViewModel.CreateDate),
            };
            var result = await _bookingFormService.UpdateForm(bookingFormDto);

            return result;
        }
    }
}
