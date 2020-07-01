using Microsoft.EntityFrameworkCore.Migrations;

namespace BicycleTestTask.Migrations
{
    public partial class Tryna_Without_Float4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Bicycles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Bicycles",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
