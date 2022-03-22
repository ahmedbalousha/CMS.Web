using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Web.Data.Migrations
{
    public partial class edit_adver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Advertisements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
