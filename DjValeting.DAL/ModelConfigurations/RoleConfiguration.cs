using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("TBL_ROLE");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnType("nvarchar(250)").HasColumnName("ROLE_NAME").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)").HasColumnName("DESCRIPTION");
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("IS_ACTIVE").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();

            builder.HasData(
                new Role
                {
                    Id = new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                    Name = "User",
                    Description = string.Empty,
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new Role
                {
                    Id = new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                    Name = "Admin",
                    Description = string.Empty,
                    CreateDate = DateTime.Now,
                    IsActive = true
                }
                );
        }
    }
}
