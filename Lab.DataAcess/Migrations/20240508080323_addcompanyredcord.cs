using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addcompanyredcord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Dist", "Name", "Pincode", "Pnumb" },
                values: new object[,]
                {
                    { 1, "Baragachha", "Amba", "tulasi", "Chiku", 566, 1 },
                    { 2, "Baragdsdachha", "Amdba", "tuldcasi", "Chdiku", 566, 12 },
                    { 3, "Baragaachha", "Adxcmba", "tusxdlasi", "Chdfiku", 56236, 132 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
