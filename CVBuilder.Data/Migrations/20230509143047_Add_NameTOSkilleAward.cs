using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVBuilder.Data.Migrations
{
    public partial class Add_NameTOSkilleAward : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Awards");
        }
    }
}
