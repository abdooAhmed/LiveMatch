using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateServerName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_serverLinks_ServerNameId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_serverNames_ServerNameId1",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_ServerNameId1",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "ServerNameId1",
                table: "Matches");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_serverNames_ServerNameId",
                table: "Matches",
                column: "ServerNameId",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_serverNames_ServerNameId",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "ServerNameId1",
                table: "Matches",
                type: "int",
                nullable: true);

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
    }
}
