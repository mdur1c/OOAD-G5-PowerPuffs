using Microsoft.EntityFrameworkCore.Migrations;

namespace EduConnect.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Statistics_StatisticsId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Statistics_StatisticsId",
                table: "Tutor");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropIndex(
                name: "IX_Tutor_StatisticsId",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_StatisticsId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "StatisticsId",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "StatisticsId",
                table: "Reviews");

            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                table: "Appointment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatisticsId",
                table: "Tutor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatisticsId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_StatisticsId",
                table: "Tutor",
                column: "StatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StatisticsId",
                table: "Reviews",
                column: "StatisticsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Statistics_StatisticsId",
                table: "Reviews",
                column: "StatisticsId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Statistics_StatisticsId",
                table: "Tutor",
                column: "StatisticsId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
