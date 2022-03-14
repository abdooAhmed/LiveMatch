using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class UpdateDatabase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Leagues_LeagueId1",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_LeagueId1",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "LeagueId1",
                table: "Clubs");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Clubs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_LeagueId",
                table: "Clubs",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Leagues_LeagueId",
                table: "Clubs",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Leagues_LeagueId",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_LeagueId",
                table: "Clubs");

            migrationBuilder.AlterColumn<string>(
                name: "LeagueId",
                table: "Clubs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LeagueId1",
                table: "Clubs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_LeagueId1",
                table: "Clubs",
                column: "LeagueId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Leagues_LeagueId1",
                table: "Clubs",
                column: "LeagueId1",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
