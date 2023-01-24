namespace DjValeting.WebUI.Models
{
    public class BookingFormViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Guid FlexibilityId { get; set; }
        public Guid VehicleSizeId { get; set; }
        public string CreateDate { get; set; }
    }
}
