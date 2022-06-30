using Microsoft.EntityFrameworkCore.Migrations;

namespace EXAM.Migrations
{
    public partial class Examss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
