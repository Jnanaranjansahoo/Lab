using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addAppointmenttodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMobile = table.Column<int>(type: "int", nullable: false),
                    CDist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPin = table.Column<int>(type: "int", nullable: false),
                    CLandMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicaationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_ApplicaationUserId",
                        column: x => x.ApplicaationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ApplicaationUserId",
                table: "Appointments",
                column: "ApplicaationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
