using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class UserRoleMappingConfiguration : IEntityTypeConfiguration<UserRoleMapping>
    {
        public void Configure(EntityTypeBuilder<UserRoleMapping> builder)
        {
            builder.ToTable("TBL_USER_ROLE_MAPPING");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.UserId).HasColumnType("uniqueidentifier").HasColumnName("USER_ID").IsRequired();
            builder.Property(x => x.RoleId).HasColumnType("uniqueidentifier").HasColumnName("ROLE_ID").IsRequired();
            builder.Property(x => x.Name).HasColumnType("nvarchar(250)").HasColumnName("ROLE_NAME").IsRequired();
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("IS_ACTIVE").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            builder.HasData(
                new UserRoleMapping
                {
                    Id = Guid.NewGuid(),
                    Name = "User",
                    UserId = new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"),
                    RoleId = new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                    CreateDate = DateTime.Now,
                    IsActive = true,
                },
                new UserRoleMapping
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    UserId = new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"),
                    RoleId = new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                    CreateDate = DateTime.Now,
                    IsActive = true,
                }
                );
        }
    }
}
