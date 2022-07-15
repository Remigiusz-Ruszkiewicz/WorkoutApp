using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace workoutapp.Migrations
{
    public partial class @new : Migration
    {
        /// <summary>
        ///     <para>
        ///         Builds the operations that will migrate the database 'up'.
        ///     </para>
        ///     <para>
        ///         That is, builds the operations that will take the database from the state left in by the
        ///         previous migration so that it is up-to-date with regard to this migration.
        ///     </para>
        ///     <para>
        ///         This method must be overridden in each class the inherits from <see cref="Migration" />.
        ///     </para>
        /// </summary>
        /// <param name="migrationBuilder"> The <see cref="MigrationBuilder" /> that will build the operations. </param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountsLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Pass = table.Column<string>(nullable: true),
                    EmailAdress = table.Column<string>(nullable: true),
                    SmtpServer = table.Column<string>(nullable: true),
                    SmtpPort = table.Column<int>(nullable: false),
                    PopServer = table.Column<string>(nullable: true),
                    PopPort = table.Column<int>(nullable: false),
                    IsPrivate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountsLists", x => x.Id);
                });

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
                name: "emailAccountLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailAccountLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "workout",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Results = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    WorkoutId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_exercises_workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exercises_WorkoutId",
                table: "exercises",
                column: "WorkoutId");
        }

        /// <summary>
        ///     <para>
        ///         Builds the operations that will migrate the database 'down'.
        ///     </para>
        ///     <para>
        ///         That is, builds the operations that will take the database from the state left in by
        ///         this migration so that it returns to the state that it was in before this migration was applied.
        ///     </para>
        ///     <para>
        ///         This method must be overridden in each class the inherits from <see cref="Migration" /> if
        ///         both 'up' and 'down' migrations are to be supported. If it is not overridden, then calling it
        ///         will throw and it will not be possible to migrate in the 'down' direction.
        ///     </para>
        /// </summary>
        /// <param name="migrationBuilder"> The <see cref="MigrationBuilder" /> that will build the operations. </param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountsLists");

            migrationBuilder.DropTable(
                name: "BMIResults");

            migrationBuilder.DropTable(
                name: "BodyFatCalculator");

            migrationBuilder.DropTable(
                name: "BodyMeasure");

            migrationBuilder.DropTable(
                name: "emailAccountLists");

            migrationBuilder.DropTable(
                name: "exercises");

            migrationBuilder.DropTable(
                name: "workout");
        }
    }
}
