using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class VehicleSizeConfiguration : IEntityTypeConfiguration<VehicleSize>
    {
        public void Configure(EntityTypeBuilder<VehicleSize> builder)
        {
            builder.ToTable("TBL_VEHICLE_SIZE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnType("nvarchar(250)").HasColumnName("VEHICLE_SIZE").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)").HasColumnName("DESCRIPTION");
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("IS_ACTIVE").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            builder.HasData(
                new VehicleSize
                {
                    Id = new Guid("4578252c-b30c-4aca-b086-cab33d1ae62d"),
                    Name = "Small",
                    CreateDate = DateTime.Now,
                    Description = string.Empty,
                    IsActive = true
                },
                new VehicleSize
                {
                    Id = new Guid("4982aab4-6da1-4d0c-8237-33436e0e6aa0"),
                    Name = "Medium",
                    CreateDate = DateTime.Now,
                    Description = string.Empty,
                    IsActive = true
                },
                new VehicleSize
                {
                    Id = new Guid("f97e6880-380f-4112-b85d-5eb3194a8b94"),
                    Name = "Large",
                    CreateDate = DateTime.Now,
                    Description = string.Empty,
                    IsActive = true
                },
                new VehicleSize
                {
                    Id = new Guid("ef95df3d-c65e-45c2-8fd8-69114c31869b"),
                    Name = "Van",
                    CreateDate = DateTime.Now,
                    Description = string.Empty,
                    IsActive = true
                }
                );
        }
    }
}
