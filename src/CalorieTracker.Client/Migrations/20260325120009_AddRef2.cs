using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTracker.Client.Migrations
{
    /// <inheritdoc />
    public partial class AddRef2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 0, 9, 117, DateTimeKind.Utc).AddTicks(8941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 11, 53, 38, 629, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 12, 0, 9, 117, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 11, 53, 38, 629, DateTimeKind.Utc).AddTicks(3396));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 11, 53, 38, 629, DateTimeKind.Utc).AddTicks(9161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 0, 9, 117, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 3, 25, 11, 53, 38, 629, DateTimeKind.Utc).AddTicks(3396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 3, 25, 12, 0, 9, 117, DateTimeKind.Utc).AddTicks(2425));
        }
    }
}
