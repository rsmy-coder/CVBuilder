using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVBuilder.Data.Migrations
{
    public partial class Add_fKToExperincec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ExperienceDbEntities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDbEntities_UserId",
                table: "ExperienceDbEntities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDbEntities_AspNetUsers_UserId",
                table: "ExperienceDbEntities");

            migrationBuilder.DropIndex(
                name: "IX_ExperienceDbEntities_UserId",
                table: "ExperienceDbEntities");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExperienceDbEntities");
        }
    }
}
