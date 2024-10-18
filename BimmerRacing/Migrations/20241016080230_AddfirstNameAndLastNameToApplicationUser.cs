using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimmerRacing.Migrations
{
    /// <inheritdoc />
    public partial class AddfirstNameAndLastNameToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "12a87da2-46d0-4f90-8386-2d135e313856", "admin@auroraauto.com", "Admin", "Rafi", "ADMIN@AURORAAUTO.COM", "ADMIN@AURORAAUTO.COM", "AQAAAAIAAYagAAAAEMjxAJ5oE/H/qy7DEshaLttmN6Kl6euwZ2vrsB9+i8g0GDP0F5UcyjtFoJb+3DbIQw==", "55fb6774-13e7-42a1-99ef-7cf41e1acee7", "admin@auroraauto.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", null, "Staff", "STAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9eef9c2c-481c-468e-8cd0-f7d6da5552fd", "admin@bimmerracing.com", "ADMIN@BIMMERRACING.COM", "ADMIN", "AQAAAAIAAYagAAAAEFDaHx/evVonWzb15g3+nk+TBwmf6wnBRWNaUYdPuKPaJ/uGMjUCJ2bwdcuVT1rouQ==", "915da0a5-0114-4b55-8be1-8b980494a6aa", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "56109e3c-bbab-4d10-9717-59bb7f286485", "ac119820@avcol.school.nz", true, false, null, "AC119820@AVCOL.SCHOOL.NZ", "Rafi", "AQAAAAIAAYagAAAAEF7+1BESWciDkvO/dm6t4lZ+SU9CY2MXHbje1fmsO93lTWwTBRegkflu74RCRlO7Bg==", null, false, "c7e53c74-2466-4317-8271-fcd64ccf9709", false, "Rafi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });
        }
    }
}
