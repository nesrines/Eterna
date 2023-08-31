using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna.Migrations
{
    public partial class UpdatedFeaturesTable_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Features",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Features",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
