using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace DjValeting.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IFlexibilityService _flexibilityService;
        private readonly IVehicleSizeService _vehicleSizeService;
        private readonly IBookingFormService _bookingFormService;
        public UserController(IFlexibilityService flexibilityService, IVehicleSizeService vehicleSizeService, IBookingFormService bookingFormService)
        {
            _flexibilityService = flexibilityService;
            _vehicleSizeService = vehicleSizeService;
            _bookingFormService = bookingFormService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var flexibilityList = await _flexibilityService.GetAllAsync();
            var vehicleSizeList = await _vehicleSizeService.GetAllAsync();
            BookingFormList bookingFormList = new()
            {
                FlexibilityDtos = flexibilityList.ToList(),
                VehicleSizeDtos = vehicleSizeList.ToList(),
            };
            return View(bookingFormList);
        }

        [HttpPost]
        public async Task<BookingFormDto> CreateForm(BookingFormViewModel bookingFormViewModel)
        {
            try
            {
                BookingFormDto bookingFormDto = new()
                {
                    Id = Guid.NewGuid(),
                    Name = bookingFormViewModel.Name,
                    Email = bookingFormViewModel.Email,
                    FlexibilityId = bookingFormViewModel.FlexibilityId,
                    VehicleSizeId = bookingFormViewModel.VehicleSizeId,
                    ContactNumber = bookingFormViewModel.ContactNumber,
                    IsActive = false,
                    CreateDate = Convert.ToDateTime(bookingFormViewModel.CreateDate),
                };
                var result = await _bookingFormService.AddAsync(bookingFormDto);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
           
            

            
        }
    }
}
