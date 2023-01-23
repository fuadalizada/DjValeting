using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjValeting.DAL.ModelConfigurations
{
    public class FlexibilityConfiguration : IEntityTypeConfiguration<Flexibility>
    {
        public void Configure(EntityTypeBuilder<Flexibility> builder)
        {
            builder.ToTable("TBL_FLEXIBILITY");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).HasColumnType("nvarchar(250)").HasColumnName("FLEXIBILITY_NAME").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)").HasColumnName("DESCRIPTION");
            builder.Property(x => x.IsActive).HasColumnType("bit").HasColumnName("IS_ACTIVE").IsRequired();
            builder.Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            builder.HasData(
                new Flexibility
                {
                    Id = new Guid("1118c02b-d0af-42e5-9a96-9bcbf931e454"),
                    Name = "1 Day",
                    Description = string.Empty,
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new Flexibility
                {
                    Id = new Guid("f91e12ba-cd7a-40bf-a369-f9e1e5f65547"),
                    Name = "2 Days",
                    Description = string.Empty,
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new Flexibility
                {
                    Id = new Guid("ffc40b16-76ef-4331-9ca8-27bd63d700bc"),
                    Name = "3 Days",
                    Description = string.Empty,
                    CreateDate = DateTime.Now,
                    IsActive = true
                }
                );
        }
    }
}
