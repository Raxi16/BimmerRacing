using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimmerRacing.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAdminLoginDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6b37955b-7dcd-43cc-916b-0c05df942373", "admin@bimmerracing.com", "ADMIN@BIMMERRACING.COM", "ADMIN@BIMMERRACING.COM", "AQAAAAIAAYagAAAAEK1lirYBiSC0BxwXU3kzdegCEa6hrJDQtg1r/3IPKZ2AdYIZ7UCHkec9xjfxk+AUhw==", "3f649939-5d5f-4319-a5f5-5d4b8affcb38", "admin@bimmerracing.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "12a87da2-46d0-4f90-8386-2d135e313856", "admin@auroraauto.com", "ADMIN@AURORAAUTO.COM", "ADMIN@AURORAAUTO.COM", "AQAAAAIAAYagAAAAEMjxAJ5oE/H/qy7DEshaLttmN6Kl6euwZ2vrsB9+i8g0GDP0F5UcyjtFoJb+3DbIQw==", "55fb6774-13e7-42a1-99ef-7cf41e1acee7", "admin@auroraauto.com" });
        }
    }
}
