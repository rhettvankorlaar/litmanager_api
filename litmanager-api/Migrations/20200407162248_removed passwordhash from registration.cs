using Microsoft.EntityFrameworkCore.Migrations;

namespace litmanager_api.Migrations
{
    public partial class removedpasswordhashfromregistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Registrations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Registrations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
