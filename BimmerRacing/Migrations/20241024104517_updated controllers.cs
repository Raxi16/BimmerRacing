using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimmerRacing.Migrations
{
    /// <inheritdoc />
    public partial class updatedcontrollers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e98a92a-8d7e-4f05-9184-caa3d55f827f", "AQAAAAIAAYagAAAAEMYY9D6y2tPbE8n/o+TsHFkqjoXrFsjtsgmrnPFD2fC+rqzkkE4UpiLfTZktbjlQHg==", "518297c1-fdde-434b-99b6-7cba5255583b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82db669d-e4b8-41b9-855d-69e2249b1d5e", "AQAAAAIAAYagAAAAEIoaYxpBQBd3aFaPGKqVnKiWLEtwglLSyrKyfOYwPu2WHFFCS+91f1Az+qrzFKxvLg==", "e7d6db26-a25f-4330-a18e-776bec75c929" });
        }
    }
}
