using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DjValeting.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_BOOKING_FORM",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CONTACTNUMBER = table.Column<string>(name: "CONTACT_NUMBER", type: "nvarchar(100)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    FLEXIBILITYID = table.Column<Guid>(name: "FLEXIBILITY_ID", type: "uniqueidentifier", nullable: false),
                    VEHICLESIZEID = table.Column<Guid>(name: "VEHICLE_SIZE_ID", type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BOOKING_FORM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_FLEXIBILITY",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FLEXIBILITYNAME = table.Column<string>(name: "FLEXIBILITY_NAME", type: "nvarchar(250)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_FLEXIBILITY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ROLE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROLENAME = table.Column<string>(name: "ROLE_NAME", type: "nvarchar(250)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    PASSWORDHASH = table.Column<string>(name: "PASSWORD_HASH", type: "nvarchar(max)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USER_ROLE_MAPPING",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USERID = table.Column<Guid>(name: "USER_ID", type: "uniqueidentifier", nullable: false),
                    ROLEID = table.Column<Guid>(name: "ROLE_ID", type: "uniqueidentifier", nullable: false),
                    ROLENAME = table.Column<string>(name: "ROLE_NAME", type: "nvarchar(250)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USER_ROLE_MAPPING", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VEHICLE_SIZE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEHICLESIZE = table.Column<string>(name: "VEHICLE_SIZE", type: "nvarchar(250)", nullable: false),
                    ISACTIVE = table.Column<bool>(name: "IS_ACTIVE", type: "bit", nullable: false),
                    CREATEDATE = table.Column<DateTime>(name: "CREATE_DATE", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VEHICLE_SIZE", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TBL_FLEXIBILITY",
                columns: new[] { "ID", "CREATE_DATE", "DESCRIPTION", "IS_ACTIVE", "FLEXIBILITY_NAME" },
                values: new object[,]
                {
                    { new Guid("1118c02b-d0af-42e5-9a96-9bcbf931e454"), new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1565), "", true, "1 Day" },
                    { new Guid("f91e12ba-cd7a-40bf-a369-f9e1e5f65547"), new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1575), "", true, "2 Days" },
                    { new Guid("ffc40b16-76ef-4331-9ca8-27bd63d700bc"), new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1577), "", true, "3 Days" }
                });

            migrationBuilder.InsertData(
                table: "TBL_ROLE",
                columns: new[] { "ID", "CREATE_DATE", "DESCRIPTION", "IS_ACTIVE", "ROLE_NAME" },
                values: new object[,]
                {
                    { new Guid("11f35b5a-0272-488f-890c-7489845ad73e"), new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(2282), "", true, "User" },
                    { new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"), new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(2284), "", true, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "TBL_USER",
                columns: new[] { "ID", "CREATE_DATE", "EMAIL", "IS_ACTIVE", "NAME", "PASSWORD_HASH" },
                values: new object[,]
                {
                    { new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"), new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(4672), "admin@yahoo.com", true, "Admin", "$2a$11$bF8iJ0Mg77hGQgvruBuL1O02zGkEadKDlV1JtyqUooA4f9sspYHuC" },
                    { new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"), new DateTime(2023, 1, 23, 16, 6, 21, 451, DateTimeKind.Local).AddTicks(9510), "fuad.alizade@yahoo.com", true, "User", "$2a$11$BRk51hKxhNgy5gEvS28grO4RHHbcHeDdqYM4gt/DRT/hiS8fExtBe" }
                });

            migrationBuilder.InsertData(
                table: "TBL_USER_ROLE_MAPPING",
                columns: new[] { "ID", "CREATE_DATE", "IS_ACTIVE", "ROLE_NAME", "ROLE_ID", "USER_ID" },
                values: new object[,]
                {
                    { new Guid("b2a3c743-af4b-4a90-a029-e0631a4bc774"), new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(9350), true, "Admin", new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"), new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9") },
                    { new Guid("ed6ab6e5-0ef8-486b-8e25-c7dda3785f88"), new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(9339), true, "User", new Guid("11f35b5a-0272-488f-890c-7489845ad73e"), new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c") }
                });

            migrationBuilder.InsertData(
                table: "TBL_VEHICLE_SIZE",
                columns: new[] { "ID", "CREATE_DATE", "DESCRIPTION", "IS_ACTIVE", "VEHICLE_SIZE" },
                values: new object[,]
                {
                    { new Guid("4578252c-b30c-4aca-b086-cab33d1ae62d"), new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2015), "", true, "Small" },
                    { new Guid("4982aab4-6da1-4d0c-8237-33436e0e6aa0"), new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2019), "", true, "Medium" },
                    { new Guid("ef95df3d-c65e-45c2-8fd8-69114c31869b"), new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2022), "", true, "Van" },
                    { new Guid("f97e6880-380f-4112-b85d-5eb3194a8b94"), new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2021), "", true, "Large" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_BOOKING_FORM");

            migrationBuilder.DropTable(
                name: "TBL_FLEXIBILITY");

            migrationBuilder.DropTable(
                name: "TBL_ROLE");

            migrationBuilder.DropTable(
                name: "TBL_USER");

            migrationBuilder.DropTable(
                name: "TBL_USER_ROLE_MAPPING");

            migrationBuilder.DropTable(
                name: "TBL_VEHICLE_SIZE");
        }
    }
}
