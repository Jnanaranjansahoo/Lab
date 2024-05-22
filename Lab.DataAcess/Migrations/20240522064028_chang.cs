using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class chang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Totalclient",
                value: null);

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Totalclient",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Totalclient",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Totalclient",
                value: 7);
        }
    }
}
