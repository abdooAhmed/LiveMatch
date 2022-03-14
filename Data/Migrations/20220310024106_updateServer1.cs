using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateServer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchServerName_Servers_serverNamesId",
                table: "MatchServerName");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerLink_Servers_ServerNameId",
                table: "ServerLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servers",
                table: "Servers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServerLink",
                table: "ServerLink");

            migrationBuilder.RenameTable(
                name: "Servers",
                newName: "serverNames");

            migrationBuilder.RenameTable(
                name: "ServerLink",
                newName: "serverLinks");

            migrationBuilder.RenameIndex(
                name: "IX_ServerLink_ServerNameId",
                table: "serverLinks",
                newName: "IX_serverLinks_ServerNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serverNames",
                table: "serverNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serverLinks",
                table: "serverLinks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchServerName_serverNames_serverNamesId",
                table: "MatchServerName",
                column: "serverNamesId",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks",
                column: "ServerNameId",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchServerName_serverNames_serverNamesId",
                table: "MatchServerName");

            migrationBuilder.DropForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serverNames",
                table: "serverNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serverLinks",
                table: "serverLinks");

            migrationBuilder.RenameTable(
                name: "serverNames",
                newName: "Servers");

            migrationBuilder.RenameTable(
                name: "serverLinks",
                newName: "ServerLink");

            migrationBuilder.RenameIndex(
                name: "IX_serverLinks_ServerNameId",
                table: "ServerLink",
                newName: "IX_ServerLink_ServerNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servers",
                table: "Servers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServerLink",
                table: "ServerLink",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchServerName_Servers_serverNamesId",
                table: "MatchServerName",
                column: "serverNamesId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerLink_Servers_ServerNameId",
                table: "ServerLink",
                column: "ServerNameId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
