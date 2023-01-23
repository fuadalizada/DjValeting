namespace DjValeting.Business.DTOs
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
