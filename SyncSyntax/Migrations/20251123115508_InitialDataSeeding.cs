using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyncSyntax.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "PublishedDate", "Title" },
                values: new object[] { "Content of LifeStyle.", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LifeStyle" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2025, 11, 23, 17, 21, 10, 397, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateTime(2025, 11, 23, 17, 21, 10, 399, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "PublishedDate", "Title" },
                values: new object[] { "Experiences from traveling around the globe.", new DateTime(2025, 11, 23, 17, 21, 10, 399, DateTimeKind.Local).AddTicks(9414), "Traveling the World" });
        }
    }
}
