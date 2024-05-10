using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addchangesttodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Officers");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "AspNetUsers",
                newName: "OfficerId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_OfficerId");

            migrationBuilder.AddColumn<int>(
                name: "Aadhar",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dist",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pancard",
                table: "Officers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pnumb",
                table: "Officers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aadhar", "Address", "City", "Dist", "Name", "Pancard", "Pincode", "Pnumb" },
                values: new object[] { 4576, "Baragachha", "Amba", "tulasi", "Chiku", "462gfsdg", 566, 1 });

            migrationBuilder.UpdateData(
                table: "Officers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aadhar", "Address", "City", "Dist", "Name", "Pancard", "Pincode", "Pnumb" },
                values: new object[] { 45736, "Baragdsdachha", "Amdba", "tuldcasi", "Chdiku", "46dt2gfsdg", 566, 12 });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Officers_OfficerId",
                table: "AspNetUsers",
                column: "OfficerId",
                principalTable: "Officers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Officers_OfficerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Aadhar",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Dist",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Pancard",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Officers");

            migrationBuilder.DropColumn(
                name: "Pnumb",
                table: "Officers");

            migrationBuilder.RenameColumn(
                name: "OfficerId",
                table: "AspNetUsers",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_OfficerId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Officers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    Pnumb = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Dist", "Name", "Pincode", "Pnumb" },
                values: new object[,]
                {
                    { 1, "Baragachha", "Amba", "tulasi", "Chiku", 566, 1 },
                    { 2, "Baragdsdachha", "Amdba", "tuldcasi", "Chdiku", 566, 12 },
                    { 3, "Baragaachha", "Adxcmba", "tusxdlasi", "Chdfiku", 56236, 132 }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
