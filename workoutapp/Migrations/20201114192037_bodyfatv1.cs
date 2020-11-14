using Microsoft.EntityFrameworkCore.Migrations;

namespace workoutapp.Migrations
{
    public partial class bodyfatv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BodyFatPercentage",
                table: "BodyFatCalculator",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyFatPercentage",
                table: "BodyFatCalculator");
        }
    }
}
