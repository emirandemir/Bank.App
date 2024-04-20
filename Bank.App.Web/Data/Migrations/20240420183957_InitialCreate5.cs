using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank.App.Web.Data.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ApplicationUsers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApplicationUsers",
                newName: "ApplicationUserId");
        }
    }
}
