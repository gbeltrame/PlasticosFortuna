using Microsoft.EntityFrameworkCore.Migrations;

namespace PlasticosFortuna.Data.Migrations
{
    public partial class UpdatedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "UserModel");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "UserModel");

            migrationBuilder.AddColumn<string>(
                name: "LoginId",
                table: "UserModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "UserModel");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "UserModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "UserModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
