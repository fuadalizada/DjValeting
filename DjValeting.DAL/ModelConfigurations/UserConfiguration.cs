using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TBL_USER");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnName("NAME").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("EMAIL").HasColumnType("nvarchar(250)").IsRequired();
            builder.Property(x => x.PasswordHash).HasColumnName("PASSWORD_HASH").HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.IsActive).HasColumnName("IS_ACTIVE").HasColumnType("bit").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").HasColumnType("datetime").IsRequired();

            builder.HasData(
                new User
                {
                    Id = new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"),
                    Email = "fuad.alizade@yahoo.com",
                    Name = "User",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User"),
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new User
                {
                    Id = new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"),
                    Email = "admin@yahoo.com",
                    Name = "Admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin"),
                    CreateDate = DateTime.Now,
                    IsActive = true
                }
                );
        }
    }
}
