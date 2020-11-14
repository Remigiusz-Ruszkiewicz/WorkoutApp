using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workoutapp.Migrations
{
    public partial class bodyfat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FatMass = table.Column<double>(nullable: false),
                    LeanMass = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyFatCalculator", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyFatCalculator");
        }
    }
}
