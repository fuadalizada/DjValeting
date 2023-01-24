using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DjValeting.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationshipOnBookingForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TBL_USER_ROLE_MAPPING",
                keyColumn: "ID",
                keyValue: new Guid("b2a3c743-af4b-4a90-a029-e0631a4bc774"));

            migrationBuilder.DeleteData(
                table: "TBL_USER_ROLE_MAPPING",
                keyColumn: "ID",
                keyValue: new Guid("ed6ab6e5-0ef8-486b-8e25-c7dda3785f88"));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("1118c02b-d0af-42e5-9a96-9bcbf931e454"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("f91e12ba-cd7a-40bf-a369-f9e1e5f65547"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("ffc40b16-76ef-4331-9ca8-27bd63d700bc"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "TBL_ROLE",
                keyColumn: "ID",
                keyValue: new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "TBL_ROLE",
                keyColumn: "ID",
                keyValue: new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 312, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "TBL_USER",
                keyColumn: "ID",
                keyValue: new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"),
                columns: new[] { "CREATE_DATE", "PASSWORD_HASH" },
                values: new object[] { new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(6227), "$2a$11$2Bvj5fbC31dkmPm7kqlSQe8af4KUCw.5tuck0TY6AKWBiG3W6CGZG" });

            migrationBuilder.UpdateData(
                table: "TBL_USER",
                keyColumn: "ID",
                keyValue: new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"),
                columns: new[] { "CREATE_DATE", "PASSWORD_HASH" },
                values: new object[] { new DateTime(2023, 1, 24, 11, 49, 51, 454, DateTimeKind.Local).AddTicks(3837), "$2a$11$8wWfEv/5qJaPx0vARfCjquzDx2VRFh6NkYfKQGKQztY0AECyIL/SK" });

            migrationBuilder.InsertData(
                table: "TBL_USER_ROLE_MAPPING",
                columns: new[] { "ID", "CREATE_DATE", "IS_ACTIVE", "ROLE_NAME", "ROLE_ID", "USER_ID" },
                values: new object[,]
                {
                    { new Guid("9a611011-a628-49e1-b046-199bc6cb6e28"), new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9081), true, "User", new Guid("11f35b5a-0272-488f-890c-7489845ad73e"), new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c") },
                    { new Guid("e88382af-4dc7-4ea4-854d-f4a397ec18fe"), new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9086), true, "Admin", new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"), new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9") }
                });

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("4578252c-b30c-4aca-b086-cab33d1ae62d"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("4982aab4-6da1-4d0c-8237-33436e0e6aa0"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("ef95df3d-c65e-45c2-8fd8-69114c31869b"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("f97e6880-380f-4112-b85d-5eb3194a8b94"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 24, 11, 49, 51, 596, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BOOKING_FORM_FLEXIBILITY_ID",
                table: "TBL_BOOKING_FORM",
                column: "FLEXIBILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_BOOKING_FORM_VEHICLE_SIZE_ID",
                table: "TBL_BOOKING_FORM",
                column: "VEHICLE_SIZE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_BOOKING_FORM_TBL_FLEXIBILITY_FLEXIBILITY_ID",
                table: "TBL_BOOKING_FORM",
                column: "FLEXIBILITY_ID",
                principalTable: "TBL_FLEXIBILITY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_BOOKING_FORM_TBL_VEHICLE_SIZE_VEHICLE_SIZE_ID",
                table: "TBL_BOOKING_FORM",
                column: "VEHICLE_SIZE_ID",
                principalTable: "TBL_VEHICLE_SIZE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_BOOKING_FORM_TBL_FLEXIBILITY_FLEXIBILITY_ID",
                table: "TBL_BOOKING_FORM");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_BOOKING_FORM_TBL_VEHICLE_SIZE_VEHICLE_SIZE_ID",
                table: "TBL_BOOKING_FORM");

            migrationBuilder.DropIndex(
                name: "IX_TBL_BOOKING_FORM_FLEXIBILITY_ID",
                table: "TBL_BOOKING_FORM");

            migrationBuilder.DropIndex(
                name: "IX_TBL_BOOKING_FORM_VEHICLE_SIZE_ID",
                table: "TBL_BOOKING_FORM");

            migrationBuilder.DeleteData(
                table: "TBL_USER_ROLE_MAPPING",
                keyColumn: "ID",
                keyValue: new Guid("9a611011-a628-49e1-b046-199bc6cb6e28"));

            migrationBuilder.DeleteData(
                table: "TBL_USER_ROLE_MAPPING",
                keyColumn: "ID",
                keyValue: new Guid("e88382af-4dc7-4ea4-854d-f4a397ec18fe"));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("1118c02b-d0af-42e5-9a96-9bcbf931e454"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("f91e12ba-cd7a-40bf-a369-f9e1e5f65547"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "TBL_FLEXIBILITY",
                keyColumn: "ID",
                keyValue: new Guid("ffc40b16-76ef-4331-9ca8-27bd63d700bc"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "TBL_ROLE",
                keyColumn: "ID",
                keyValue: new Guid("11f35b5a-0272-488f-890c-7489845ad73e"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "TBL_ROLE",
                keyColumn: "ID",
                keyValue: new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 313, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "TBL_USER",
                keyColumn: "ID",
                keyValue: new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9"),
                columns: new[] { "CREATE_DATE", "PASSWORD_HASH" },
                values: new object[] { new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(4672), "$2a$11$bF8iJ0Mg77hGQgvruBuL1O02zGkEadKDlV1JtyqUooA4f9sspYHuC" });

            migrationBuilder.UpdateData(
                table: "TBL_USER",
                keyColumn: "ID",
                keyValue: new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c"),
                columns: new[] { "CREATE_DATE", "PASSWORD_HASH" },
                values: new object[] { new DateTime(2023, 1, 23, 16, 6, 21, 451, DateTimeKind.Local).AddTicks(9510), "$2a$11$BRk51hKxhNgy5gEvS28grO4RHHbcHeDdqYM4gt/DRT/hiS8fExtBe" });

            migrationBuilder.InsertData(
                table: "TBL_USER_ROLE_MAPPING",
                columns: new[] { "ID", "CREATE_DATE", "IS_ACTIVE", "ROLE_NAME", "ROLE_ID", "USER_ID" },
                values: new object[,]
                {
                    { new Guid("b2a3c743-af4b-4a90-a029-e0631a4bc774"), new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(9350), true, "Admin", new Guid("5d81a0c8-d8bf-4d18-b0a7-4ad53eee724e"), new Guid("53b70581-70a7-4878-9b7b-4d81a69cc5d9") },
                    { new Guid("ed6ab6e5-0ef8-486b-8e25-c7dda3785f88"), new DateTime(2023, 1, 23, 16, 6, 21, 604, DateTimeKind.Local).AddTicks(9339), true, "User", new Guid("11f35b5a-0272-488f-890c-7489845ad73e"), new Guid("cb2830d0-8555-4553-a894-22ab9ca0b79c") }
                });

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("4578252c-b30c-4aca-b086-cab33d1ae62d"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("4982aab4-6da1-4d0c-8237-33436e0e6aa0"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("ef95df3d-c65e-45c2-8fd8-69114c31869b"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "TBL_VEHICLE_SIZE",
                keyColumn: "ID",
                keyValue: new Guid("f97e6880-380f-4112-b85d-5eb3194a8b94"),
                column: "CREATE_DATE",
                value: new DateTime(2023, 1, 23, 16, 6, 21, 605, DateTimeKind.Local).AddTicks(2021));
        }
    }
}
