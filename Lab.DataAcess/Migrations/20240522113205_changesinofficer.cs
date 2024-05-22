using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class changesinofficer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Officers",
                newName: "Totalclient");

            migrationBuilder.AddColumn<string>(
                name: "Dist",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LandMark",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pin",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pos",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dist", "LandMark", "Mobile", "Name", "Pin", "Pos", "Totalclient" },
                values: new object[] { "SWD9999001", "Near bara gachha", 123456789, "Fortune ", 90, "Pankapal", 5 });

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dist", "LandMark", "Mobile", "Name", "Pin", "Pos", "Totalclient" },
                values: new object[] { "SWD9999001", "Near bara gachha", 123456789, "Time", 90, "Pankapal", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dist",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "LandMark",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Pos",
                table: "Officers");

            migrationBuilder.RenameColumn(
                name: "Totalclient",
                table: "Officers",
                newName: "Cost");

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 1, "Male" });

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 2, "FeMale" });
        }
    }
}
