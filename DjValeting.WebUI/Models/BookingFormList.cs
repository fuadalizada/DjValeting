using DjValeting.Business.DTOs;

namespace DjValeting.WebUI.Models
{
    public class BookingFormList
    {
        public List<FlexibilityDto> FlexibilityDtos { get; set; }
        public List<VehicleSizeDto> VehicleSizeDtos { get; set; }
    }
}
