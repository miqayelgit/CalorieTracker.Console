using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class AddRef4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 14, 12, 758, DateTimeKind.Utc).AddTicks(3513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 10, 25, 123, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 14, 12, 757, DateTimeKind.Utc).AddTicks(7766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 10, 25, 122, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 16, 14, 12, 756, DateTimeKind.Local).AddTicks(8732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 10, 25, 123, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 14, 12, 758, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 10, 25, 122, DateTimeKind.Utc).AddTicks(6858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 14, 12, 757, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 16, 14, 12, 756, DateTimeKind.Local).AddTicks(8732));
        }
    }
}
