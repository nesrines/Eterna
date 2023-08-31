using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    public partial class UpdatedServicesTable_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Services",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Services");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
