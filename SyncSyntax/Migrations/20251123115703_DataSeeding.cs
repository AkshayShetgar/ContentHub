using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SyncSyntax.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Posts related to technology.", "Technology" },
                    { 2, "Posts related to health and wellness.", "Health" },
                    { 3, "Posts about LifeStyle.", "LifeStyle" }
                });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "ImagePath", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Akshay", 1, "Artificial Intelligence is transforming the world.", "Akki.jpeg", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Rise of AI" },
                    { 2, "Sagar", 2, "Tips for a healthier lifestyle.", "Akki.jpeg", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Living Tips" },
                    { 3, "Ankita", 3, "Content of LifeStyle.", "Akki.jpeg", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LifeStyle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
