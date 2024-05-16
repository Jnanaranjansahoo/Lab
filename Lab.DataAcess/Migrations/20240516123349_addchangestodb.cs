using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addchangestodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CName",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dist",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandMark",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "Archives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OfficerId",
                table: "Archives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pin",
                table: "Archives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pos",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Archives",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Archives_OfficerId",
                table: "Archives",
                column: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_Officers_OfficerId",
                table: "Archives",
                column: "OfficerId",
                principalTable: "Officers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_Officers_OfficerId",
                table: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Archives_OfficerId",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "CName",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Dist",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "LandMark",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "OfficerId",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Pos",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Archives");
        }
    }
}
