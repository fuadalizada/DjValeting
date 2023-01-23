namespace DjValeting.Domain.Entities
{
    public class UserRoleMapping : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
