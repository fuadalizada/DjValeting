namespace DjValeting.Domain.Entities
{
    public class VehicleSize : BaseEntity
    {
        public VehicleSize()
        {
            BookingForms = new HashSet<BookingForm>();
        }
        public string Description { get; set; }
        public ICollection<BookingForm> BookingForms { get; set; }
    }
}
