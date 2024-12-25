using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreMvc_eTicaret_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class yusuf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2164));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8948));
        }
    }
}
