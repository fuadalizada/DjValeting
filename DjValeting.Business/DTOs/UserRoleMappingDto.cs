namespace DjValeting.Business.DTOs
{
    public class UserRoleMappingDto : BaseDto
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
