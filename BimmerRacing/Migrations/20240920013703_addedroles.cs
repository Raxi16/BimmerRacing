using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BimmerRacing.Migrations
{
    /// <inheritdoc />
    public partial class addedroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "9eef9c2c-481c-468e-8cd0-f7d6da5552fd", "admin@bimmerracing.com", true, false, null, "ADMIN@BIMMERRACING.COM", "ADMIN", "AQAAAAIAAYagAAAAEFDaHx/evVonWzb15g3+nk+TBwmf6wnBRWNaUYdPuKPaJ/uGMjUCJ2bwdcuVT1rouQ==", null, false, "915da0a5-0114-4b55-8be1-8b980494a6aa", false, "Admin" },
                    { "2", 0, "56109e3c-bbab-4d10-9717-59bb7f286485", "ac119820@avcol.school.nz", true, false, null, "AC119820@AVCOL.SCHOOL.NZ", "Rafi", "AQAAAAIAAYagAAAAEF7+1BESWciDkvO/dm6t4lZ+SU9CY2MXHbje1fmsO93lTWwTBRegkflu74RCRlO7Bg==", null, false, "c7e53c74-2466-4317-8271-fcd64ccf9709", false, "Rafi" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
