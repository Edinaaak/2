using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentaCar.Migrations
{
    public partial class AddAutomobilToDatabase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doors",
                table: "Automobili",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "doors",
                table: "Automobili");
        }
    }
}
