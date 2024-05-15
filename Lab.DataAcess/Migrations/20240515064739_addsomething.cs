using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addsomething : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "ClientId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "ClientId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "ClientId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ApplicationUserId",
                table: "Appointments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_ApplicationUserId",
                table: "Appointments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Appointments");

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
        }
    }
}
