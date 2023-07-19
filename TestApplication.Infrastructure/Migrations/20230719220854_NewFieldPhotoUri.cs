using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Infrastructure.Migrations
{
    public partial class NewFieldPhotoUri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUri",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUri",
                table: "ApplicationUsers");
        }
    }
}
