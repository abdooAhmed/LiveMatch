using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_Matches_MatchId",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Servers_MatchId",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Servers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Servers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Matches",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<int>(
                name: "club2Id",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "club1Id",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                        name: "FK_MatchServerName_Servers_serverNamesId",
                        column: x => x.serverNamesId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerNameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerLink_Servers_ServerNameId",
                        column: x => x.ServerNameId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchServerName_serverNamesId",
                table: "MatchServerName",
                column: "serverNamesId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerLink_ServerNameId",
                table: "ServerLink",
                column: "ServerNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchServerName");

            migrationBuilder.DropTable(
                name: "ServerLink");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Servers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Servers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Servers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "date",
                table: "Matches",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "club2Id",
                table: "Matches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "club1Id",
                table: "Matches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
