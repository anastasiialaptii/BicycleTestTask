using Microsoft.EntityFrameworkCore.Migrations;

namespace BicycleTestTask.Migrations
{
    public partial class Tryna_Without_Float : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Bicycles",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Bicycles",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
