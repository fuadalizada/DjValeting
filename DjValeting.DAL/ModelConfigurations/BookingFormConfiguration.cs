using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class BookingFormConfiguration : IEntityTypeConfiguration<BookingForm>
    {
        public void Configure(EntityTypeBuilder<BookingForm> builder)
        {
            builder.ToTable("TBL_BOOKING_FORM");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnType("nvarchar(250)").HasColumnName("NAME").IsRequired();
            builder.Property(x => x.ContactNumber).HasColumnType("nvarchar(100)").HasColumnName("CONTACT_NUMBER").IsRequired();
            builder.Property(x => x.Email).HasColumnName("EMAIL").HasColumnType("nvarchar(250)").IsRequired();
            builder.Property(x => x.FlexibilityId).HasColumnType("uniqueidentifier").HasColumnName("FLEXIBILITY_ID").IsRequired();
            builder.Property(x => x.VehicleSizeId).HasColumnType("uniqueidentifier") .HasColumnName("VEHICLE_SIZE_ID").IsRequired();
            builder.HasOne(x => x.Flexibility).WithMany(x => x.BookingForms).HasForeignKey(x => x.FlexibilityId);
            builder.HasOne(x=>x.VehicleSize).WithMany(x => x.BookingForms).HasForeignKey(x=>x.VehicleSizeId);
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            builder.Property(x => x.IsActive) .HasColumnType("bit").HasColumnName("IS_ACTIVE").IsRequired();
        }
    }
}
