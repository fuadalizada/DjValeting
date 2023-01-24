using DjValeting.Domain.Entities;

namespace DjValeting.Business.DTOs
{
    public class BookingFormDto : BaseDto
    {
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Guid FlexibilityId { get; set; }
        public Guid VehicleSizeId { get; set; }
        public Flexibility Flexibility { get; set; }
        public VehicleSize VehicleSize { get; set; }
    }
}
