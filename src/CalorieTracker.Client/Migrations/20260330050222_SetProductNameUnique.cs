using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class SetProductNameUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 5, 2, 22, 357, DateTimeKind.Utc).AddTicks(7226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 4, 17, 10, 212, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 5, 2, 22, 357, DateTimeKind.Utc).AddTicks(1853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 4, 17, 10, 211, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 9, 2, 22, 356, DateTimeKind.Local).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 8, 17, 10, 211, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.AddUniqueConstraint(
                name: "UQ_Products_ProductName",
                table: "Products",
                column: "ProductName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "UQ_Products_ProductName",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 4, 17, 10, 212, DateTimeKind.Utc).AddTicks(5463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 5, 2, 22, 357, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 4, 17, 10, 211, DateTimeKind.Utc).AddTicks(9433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 5, 2, 22, 357, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyCalorieLimits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 30, 8, 17, 10, 211, DateTimeKind.Local).AddTicks(1905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 30, 9, 2, 22, 356, DateTimeKind.Local).AddTicks(4136));
        }
    }
}
