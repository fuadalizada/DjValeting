// <auto-generated />
using System;
using DjValeting.DAL.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DjValeting.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DjValeting.Domain.Entities.BookingForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CONTACT_NUMBER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("EMAIL");

                    b.Property<Guid>("FlexibilityId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FLEXIBILITY_ID");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NAME");

                    b.Property<Guid>("VehicleSizeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("VEHICLE_SIZE_ID");

                    b.HasKey("Id");

                    b.HasIndex("FlexibilityId");

                    b.HasIndex("VehicleSizeId");

                    b.ToTable("TBL_BOOKING_FORM", (string)null);
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.Flexibility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("FLEXIBILITY_NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_FLEXIBILITY", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1118c02b-d0af-42e5-9a96-9bcbf931e454"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7423),
                            Description = "",
                            IsActive = true,
                            Name = "1 Day"
                        },
                        new
                        {
                            Id = new Guid("f91e12ba-cd7a-40bf-a369-f9e1e5f65547"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7433),
                            Description = "",
                            IsActive = true,
                            Name = "2 Days"
                        },
                        new
                        {
                            Id = new Guid("ffc40b16-76ef-4331-9ca8-27bd63d700bc"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7435),
                            Description = "",
                            IsActive = true,
                            Name = "3 Days"
                        });
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("ROLE_NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_ROLE", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(8249),
                            Description = "",
                            IsActive = true,
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(8252),
                            Description = "",
                            IsActive = true,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("EMAIL");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NAME");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PASSWORD_HASH");

                    b.HasKey("Id");

                    b.ToTable("TBL_USER", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 454, DateTimeKind.Local).AddTicks(3837),
                            Email = "fuad.alizade@yahoo.com",
                            IsActive = true,
                            Name = "User",
                            PasswordHash = "$2a$11$8wWfEv/5qJaPx0vARfCjquzDx2VRFh6NkYfKQGKQztY0AECyIL/SK"
                        },
                        new
                        {
                            Id = new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(6227),
                            Email = "admin@yahoo.com",
                            IsActive = true,
                            Name = "Admin",
                            PasswordHash = "$2a$11$2Bvj5fbC31dkmPm7kqlSQe8af4KUCw.5tuck0TY6AKWBiG3W6CGZG"
                        });
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.UserRoleMapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("ROLE_NAME");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ROLE_ID");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.ToTable("TBL_USER_ROLE_MAPPING", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a611011-a628-49e1-b046-199bc6cb6e28"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9081),
                            IsActive = true,
                            Name = "User",
                            RoleId = new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                            UserId = new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c")
                        },
                        new
                        {
                            Id = new Guid("e88382af-4dc7-4ea4-854d-f4a397ec18fe"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9086),
                            IsActive = true,
                            Name = "Admin",
                            RoleId = new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                            UserId = new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9")
                        });
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.VehicleSize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IS_ACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("VEHICLE_SIZE");

                    b.HasKey("Id");

                    b.ToTable("TBL_VEHICLE_SIZE", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4578252c-b30c-4aca-b086-cab33d1ae62d"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9767),
                            Description = "",
                            IsActive = true,
                            Name = "Small"
                        },
                        new
                        {
                            Id = new Guid("4982aab4-6da1-4d0c-8237-33436e0e6aa0"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9771),
                            Description = "",
                            IsActive = true,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("f97e6880-380f-4112-b85d-5eb3194a8b94"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9772),
                            Description = "",
                            IsActive = true,
                            Name = "Large"
                        },
                        new
                        {
                            Id = new Guid("ef95df3d-c65e-45c2-8fd8-69114c31869b"),
                            CreateDate = new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9773),
                            Description = "",
                            IsActive = true,
                            Name = "Van"
                        });
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.BookingForm", b =>
                {
                    b.HasOne("DjValeting.Domain.Entities.Flexibility", "Flexibility")
                        .WithMany("BookingForms")
                        .HasForeignKey("FlexibilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DjValeting.Domain.Entities.VehicleSize", "VehicleSize")
                        .WithMany("BookingForms")
                        .HasForeignKey("VehicleSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flexibility");

                    b.Navigation("VehicleSize");
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.Flexibility", b =>
                {
                    b.Navigation("BookingForms");
                });

            modelBuilder.Entity("DjValeting.Domain.Entities.VehicleSize", b =>
                {
                    b.Navigation("BookingForms");
                });
#pragma warning restore 612, 618
        }
    }
}
