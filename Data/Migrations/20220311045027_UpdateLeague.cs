using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class UpdateLeague : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_leagueId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "leagueId",
                table: "Matches",
                newName: "LeagueId");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_leagueId",
                table: "Matches",
                newName: "IX_Matches_LeagueId");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "LeagueId",
                table: "Matches",
                newName: "leagueId");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches",
                newName: "IX_Matches_leagueId");

            migrationBuilder.AlterColumn<int>(
                name: "leagueId",
                table: "Matches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leagues_leagueId",
                table: "Matches",
                column: "leagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
