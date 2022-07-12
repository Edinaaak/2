using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentaCar.Migrations
{
    public partial class AddAutomobilToDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "engine",
                table: "Automobili",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gasoline",
                table: "Automobili",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gearbox",
                table: "Automobili",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "engine",
                table: "Automobili");

            migrationBuilder.DropColumn(
                name: "gasoline",
                table: "Automobili");

            migrationBuilder.DropColumn(
                name: "gearbox",
                table: "Automobili");
        }
    }
}
