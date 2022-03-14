using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateServer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks");

            migrationBuilder.AlterColumn<int>(
                name: "ServerNameId",
                table: "serverLinks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks",
                column: "ServerNameId",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks");

            migrationBuilder.AlterColumn<int>(
                name: "ServerNameId",
                table: "serverLinks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_serverLinks_serverNames_ServerNameId",
                table: "serverLinks",
                column: "ServerNameId",
                principalTable: "serverNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
