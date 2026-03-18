using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 18, 17, 40, 49, 604, DateTimeKind.Utc).AddTicks(7348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 18, 10, 35, 32, 966, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 18, 17, 40, 49, 604, DateTimeKind.Utc).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 18, 10, 35, 32, 966, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.CreateTable(
                name: "DailyCalorieLimits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dailimit = table.Column<short>(type: "smallint", nullable: false),
                    DailyUsedLimit = table.Column<short>(type: "SMALLINT", nullable: false),
                    DailyRemainingLimit = table.Column<short>(type: "SMALLINT", nullable: false)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyCalorieLimits");

            migrationBuilder.DropTable(
                name: "DailyNutrientsIntakeAmounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 18, 10, 35, 32, 966, DateTimeKind.Utc).AddTicks(6873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 18, 17, 40, 49, 604, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 18, 10, 35, 32, 966, DateTimeKind.Utc).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 18, 17, 40, 49, 604, DateTimeKind.Utc).AddTicks(5454));
        }
    }
}
