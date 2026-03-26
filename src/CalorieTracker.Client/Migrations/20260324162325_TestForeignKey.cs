using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class TestForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityLevelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActivityLevelRate = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyCalorieLimits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyLimit = table.Column<short>(type: "smallint", nullable: false),
                    UsedLimit = table.Column<short>(type: "SMALLINT", nullable: false),
                    RemainingLimit = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyCalorieLimits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyNutrientsIntakeAmounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Protein = table.Column<short>(type: "SMALLINT", nullable: false),
                    Fat = table.Column<short>(type: "SMALLINT", nullable: false),
                    Carbs = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyNutrientsIntakeAmounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GoalValue = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessGoals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProteinPerHundredGram = table.Column<double>(type: "FLOAT", nullable: false),
                    FatPerHundredGram = table.Column<double>(type: "FLOAT", nullable: false),
                    CarbsPerHundredGram = table.Column<double>(type: "FLOAT", nullable: false),
                    CaloriesPerHundredGram = table.Column<short>(type: "SMALLINT", nullable: false),
                    VisibilityScope = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2026, 3, 24, 16, 23, 25, 398, DateTimeKind.Utc).AddTicks(9212))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Height = table.Column<short>(type: "SMALLINT", nullable: false),
                    Weight = table.Column<short>(type: "SMALLINT", nullable: false),
                    Age = table.Column<byte>(type: "TINYINT", nullable: false),
                    ActivityLevel = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FitnessGoal = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2026, 3, 24, 16, 23, 25, 399, DateTimeKind.Utc).AddTicks(1465))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("UQ_Users_Email", x => x.Email);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLevels");

            migrationBuilder.DropTable(
                name: "DailyCalorieLimits");

            migrationBuilder.DropTable(
                name: "DailyNutrientsIntakeAmounts");

            migrationBuilder.DropTable(
                name: "FitnessGoals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
