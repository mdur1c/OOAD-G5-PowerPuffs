using Microsoft.EntityFrameworkCore.Migrations;

namespace EduConnect.Migrations
{
    public partial class Migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TutorId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_TutorId",
                table: "Reviews",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Tutor_TutorId",
                table: "Reviews",
                column: "TutorId",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Tutor_TutorId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_TutorId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Reviews");
        }
    }
}
