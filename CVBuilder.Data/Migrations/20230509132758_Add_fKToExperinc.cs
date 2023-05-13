using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVBuilder.Data.Migrations
{
    public partial class Add_fKToExperinc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ExperienceDbEntities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ExperienceDbEntities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
