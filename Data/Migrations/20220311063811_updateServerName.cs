using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateServerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchServerName");

            migrationBuilder.AddColumn<int>(
                name: "ServerNameId1",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ServerNameId",
                table: "Matches",
                column: "ServerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ServerNameId1",
                table: "Matches",
                column: "ServerNameId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_serverLinks_ServerNameId",
                table: "Matches",
                column: "ServerNameId",
                principalTable: "serverLinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_serverNames_ServerNameId1",
                table: "Matches",
                column: "ServerNameId1",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_serverLinks_ServerNameId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_serverNames_ServerNameId1",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_ServerNameId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_ServerNameId1",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "ServerNameId1",
                table: "Matches");

            migrationBuilder.CreateTable(
                name: "MatchServerName",
                columns: table => new
                {
                    MatchesId = table.Column<int>(type: "int", nullable: false),
                    serverNamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchServerName", x => new { x.MatchesId, x.serverNamesId });
                    table.ForeignKey(
                        name: "FK_MatchServerName_Matches_MatchesId",
                        column: x => x.MatchesId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchServerName_serverNames_serverNamesId",
                        column: x => x.serverNamesId,
                        principalTable: "serverNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchServerName_serverNamesId",
                table: "MatchServerName",
                column: "serverNamesId");
        }
    }
}
