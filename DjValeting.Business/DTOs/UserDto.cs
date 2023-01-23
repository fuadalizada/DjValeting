namespace DjValeting.Business.DTOs
{
    public class UserDto : BaseDto
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
