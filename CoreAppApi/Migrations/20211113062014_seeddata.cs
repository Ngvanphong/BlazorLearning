using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAppApi.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0c903812-6384-4cc4-93c7-4b5ec8a91f8c"), 0, "b7183442-7d95-4faf-8737-f9c95c82abd3", "adim@gamil.com", false, "Mr", "A", false, null, null, null, "AQAAAAEAACcQAAAAEMtX9E4XBtCP2vBSAojMfCvbXmx2KDsp70GAoaYzMABtmW7iRRrYbTJibH5dUrG2ow==", "010101010", false, null, false, "adim" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AssigneeId", "CreatedDate", "Name", "Priority", "Status" },
                values: new object[] { new Guid("14335723-e1f3-481b-bb28-5a684868964e"), new Guid("0c903812-6384-4cc4-93c7-4b5ec8a91f8c"), new DateTime(2021, 11, 13, 13, 20, 13, 938, DateTimeKind.Local).AddTicks(4647), "Sample 1", 2, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: new Guid("14335723-e1f3-481b-bb28-5a684868964e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0c903812-6384-4cc4-93c7-4b5ec8a91f8c"));
        }
    }
}
