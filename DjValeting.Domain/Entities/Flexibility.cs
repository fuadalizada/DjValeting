namespace DjValeting.Domain.Entities
{
    public class Flexibility : BaseEntity
    {
        public Flexibility()
        {
            BookingForms = new HashSet<BookingForm>();
        }
        public string Description { get; set; }
        public ICollection<BookingForm> BookingForms { get; set; }
    }
}
