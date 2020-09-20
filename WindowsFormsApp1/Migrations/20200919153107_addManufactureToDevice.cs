using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    public partial class addManufactureToDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manufacture",
                table: "GamingDevices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacture",
                table: "GamingDevices");
        }
    }
}
