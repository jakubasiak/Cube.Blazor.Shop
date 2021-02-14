using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cube.Blazor.Shop.Server.Migrations
{
    public partial class RemovedProductFromCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 158, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 53, 1, 164, DateTimeKind.Local).AddTicks(8880));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 557, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 2, 15, 0, 38, 35, 562, DateTimeKind.Local).AddTicks(5483));
        }
    }
}
