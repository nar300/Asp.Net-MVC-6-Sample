using Microsoft.EntityFrameworkCore.Migrations;

namespace Newapp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Dob",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Dob",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
