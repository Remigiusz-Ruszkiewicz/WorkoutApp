using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workoutapp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BMIResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Result = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMIResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyFatCalculator",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Save = table.Column<bool>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Neck = table.Column<double>(nullable: false),
                    Waist = table.Column<double>(nullable: false),
                    Hip = table.Column<double>(nullable: false),
                    BodyFatPercentage = table.Column<double>(nullable: false),
                    FatMass = table.Column<double>(nullable: false),
                    LeanMass = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyFatCalculator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyMeasure",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Bicepsleft = table.Column<int>(nullable: false),
                    BicepsRight = table.Column<int>(nullable: false),
                    Chest = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false),
                    Midsection = table.Column<int>(nullable: false),
                    Hips = table.Column<int>(nullable: false),
                    ThighLeft = table.Column<int>(nullable: false),
                    ThighRight = table.Column<int>(nullable: false),
                    CalfLeft = table.Column<int>(nullable: false),
                    CalfRight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMIResults");

            migrationBuilder.DropTable(
                name: "BodyFatCalculator");

            migrationBuilder.DropTable(
                name: "BodyMeasure");

            migrationBuilder.DropTable(
                name: "exercises");
        }
    }
}
