using Microsoft.EntityFrameworkCore.Migrations;

namespace webappcore.Migrations
{
    public partial class AddUserNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "UserAddress",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "UserAddress");
        }
    }
}
