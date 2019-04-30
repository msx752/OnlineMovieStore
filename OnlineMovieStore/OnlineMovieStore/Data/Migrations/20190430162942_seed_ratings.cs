using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_ratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "AverageRating", "MovieId", "NumVotes" },
                values: new object[,]
                {
                    { 1, 87.0, "tt0133093", 1493180 },
                    { 15, 58.0, "tt3492330", 218 },
                    { 14, 68.0, "tt2076307", 66 },
                    { 13, 67.0, "tt1517238", 517 },
                    { 12, 64.0, "tt0870915", 260 },
                    { 11, 61.0, "tt0091805", 41 },
                    { 10, 54.0, "tt7640234", 29 },
                    { 16, 67.0, "tt6933454", 3404 },
                    { 9, 67.0, "tt7578416", 23 },
                    { 7, 67.0, "tt9024440", 15 },
                    { 6, 25.0, "tt8968844", 17 },
                    { 5, 16.0, "tt1854506", 1538 },
                    { 4, 62.0, "tt1775309", 41 },
                    { 3, 78.0, "tt0499549", 1036901 },
                    { 2, 72.0, "tt0234215", 475351 },
                    { 8, 64.0, "tt0054395", 828 },
                    { 17, 67.0, "tt7220696", 391 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
