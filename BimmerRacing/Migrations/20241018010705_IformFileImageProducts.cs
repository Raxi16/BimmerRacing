using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimmerRacing.Migrations
{
    /// <inheritdoc />
    public partial class IformFileImageProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82db669d-e4b8-41b9-855d-69e2249b1d5e", "AQAAAAIAAYagAAAAEIoaYxpBQBd3aFaPGKqVnKiWLEtwglLSyrKyfOYwPu2WHFFCS+91f1Az+qrzFKxvLg==", "e7d6db26-a25f-4330-a18e-776bec75c929" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b37955b-7dcd-43cc-916b-0c05df942373", "AQAAAAIAAYagAAAAEK1lirYBiSC0BxwXU3kzdegCEa6hrJDQtg1r/3IPKZ2AdYIZ7UCHkec9xjfxk+AUhw==", "3f649939-5d5f-4319-a5f5-5d4b8affcb38" });
        }
    }
}
