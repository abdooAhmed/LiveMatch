using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMatch.Data.Migrations
{
    public partial class updateserver3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServerNameId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServerNameId",
                table: "Matches");
        }
    }
}
