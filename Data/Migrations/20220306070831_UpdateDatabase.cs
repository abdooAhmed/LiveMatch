using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Servers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servers_MatchId",
                table: "Servers",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_Matches_MatchId",
                table: "Servers",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_Matches_MatchId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_MatchId",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Servers");
        }
    }
}
