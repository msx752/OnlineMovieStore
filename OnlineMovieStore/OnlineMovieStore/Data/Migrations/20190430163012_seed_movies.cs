using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "RatingId", "RuntimeMinutes", "StartYear", "Title", "Type" },
                values: new object[,]
                {
                    { "tt0133093", "", 1, 136, 1999, "The Matrix", 0 },
                    { "tt3492330", "", 15, 85, 2014, "Puzzle", 0 },
                    { "tt2076307", "", 14, 90, 2013, "Puzzle", 0 },
                    { "tt1517238", "", 13, 87, 2009, "Puzzle", 0 },
                    { "tt0870915", "", 12, 91, 2006, "Puzzle", 0 },
                    { "tt0091805", "", 11, 93, 1986, "Puzzle", 0 },
                    { "tt7640234", "", 10, 65, 2018, "Drown Among the Dead", 0 },
                    { "tt6933454", "", 16, 103, 2018, "Puzzle", 0 },
                    { "tt7578416", "", 9, 106, 2017, "We, the Dead", 0 },
                    { "tt9024440", "", 7, 50, 2018, "A Meowy Halloween", 0 },
                    { "tt8968844", "", 6, 80, 2018, "Samhain: A Halloween Horror Movie", 0 },
                    { "tt1854506", "", 5, 80, 2011, "Aliens vs. Avatars", 0 },
                    { "tt1775309", "", 4, 93, 2011, "Avatar", 0 },
                    { "tt0499549", "", 3, 162, 2009, "Avatar", 0 },
                    { "tt0234215", "", 2, 138, 2003, "The Matrix Reloaded", 0 },
                    { "tt0054395", "", 8, 104, 1961, "Dead Eyes of London", 0 },
                    { "tt7220696", "", 17, 103, 2018, "Laugh or Die", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0054395");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0091805");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0133093");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0234215");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0499549");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt0870915");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt1517238");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt1775309");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt1854506");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt2076307");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt3492330");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt6933454");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt7220696");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt7578416");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt7640234");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt8968844");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "tt9024440");
        }
    }
}
