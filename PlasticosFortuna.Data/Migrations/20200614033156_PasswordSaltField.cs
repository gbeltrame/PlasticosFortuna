using Microsoft.EntityFrameworkCore.Migrations;

namespace PlasticosFortuna.Data.Migrations
{
    public partial class PasswordSaltField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "UserModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "UserModel");
        }
    }
}
