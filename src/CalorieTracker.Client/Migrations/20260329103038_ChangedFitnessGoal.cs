using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFitnessGoal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalValue",
                table: "FitnessGoals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 10, 30, 38, 608, DateTimeKind.Utc).AddTicks(2769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 8, 35, 34, 143, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 10, 30, 38, 607, DateTimeKind.Utc).AddTicks(5644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 8, 35, 34, 143, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.AddColumn<byte>(
                name: "CarbsPercent",
                table: "FitnessGoals",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "FatPercent",
                table: "FitnessGoals",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "ProteinPercent",
                table: "FitnessGoals",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 14, 30, 38, 606, DateTimeKind.Local).AddTicks(8518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 12, 35, 34, 142, DateTimeKind.Local).AddTicks(3093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarbsPercent",
                table: "FitnessGoals");

            migrationBuilder.DropColumn(
                name: "FatPercent",
                table: "FitnessGoals");

            migrationBuilder.DropColumn(
                name: "ProteinPercent",
                table: "FitnessGoals");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 8, 35, 34, 143, DateTimeKind.Utc).AddTicks(6209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 10, 30, 38, 608, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 8, 35, 34, 143, DateTimeKind.Utc).AddTicks(118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 10, 30, 38, 607, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.AddColumn<float>(
                name: "GoalValue",
                table: "FitnessGoals",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 29, 12, 35, 34, 142, DateTimeKind.Local).AddTicks(3093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 29, 14, 30, 38, 606, DateTimeKind.Local).AddTicks(8518));
        }
    }
}
