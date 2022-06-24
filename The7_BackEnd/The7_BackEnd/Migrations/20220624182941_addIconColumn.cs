using Microsoft.EntityFrameworkCore.Migrations;

namespace The7_BackEnd.Migrations
{
    public partial class addIconColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceIcon",
                table: "Service",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceIcon",
                table: "Service");
        }
    }
}
