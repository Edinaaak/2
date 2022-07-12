using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentaCar.Migrations
{
    public partial class AddAutomobilToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>
                (
                name: "engine",
                table: "Automobili",
                nullable: false,
                defaultValue: ""
                );

            migrationBuilder.AddColumn<string>
                (
                name: "gearbox",
                table: "Automobili",
                nullable: false,
                defaultValue: ""
                );
            migrationBuilder.AddColumn<string>
              (
              name: "gasoline",
              table: "Automobili",
              nullable: false,
              defaultValue: ""
              );
        }
    }
}
