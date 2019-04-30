using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_moviewriters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieWriters",
                columns: new[] { "MovieId", "WriterId" },
                values: new object[,]
                {
                    { "tt0054395", "nm0908624" },
                    { "tt6933454", "nm0807023" },
                    { "tt6933454", "nm0610219" },
                    { "tt2076307", "nm0956913" },
                    { "tt1854506", "nm0827500" },
                    { "tt1854506", "nm0150043" },
                    { "tt1517238", "nm0807023" },
                    { "tt7220696", "nm0474289" },
                    { "tt0499549", "nm0000116" },
                    { "tt0234215", "nm0905152" },
                    { "tt0133093", "nm0905154" },
                    { "tt0133093", "nm0905152" },
                    { "tt0091805", "nm0173775" },
                    { "tt0054395", "nm0525742" },
                    { "tt0054395", "nm0251912" },
                    { "tt0234215", "nm0905154" },
                    { "tt7220696", "nm0718558" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0054395", "nm0251912" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0054395", "nm0525742" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0054395", "nm0908624" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0091805", "nm0173775" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0133093", "nm0905152" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0133093", "nm0905154" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0234215", "nm0905152" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0234215", "nm0905154" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt0499549", "nm0000116" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt1517238", "nm0807023" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt1854506", "nm0150043" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt1854506", "nm0827500" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt2076307", "nm0956913" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt6933454", "nm0610219" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt6933454", "nm0807023" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt7220696", "nm0474289" });

            migrationBuilder.DeleteData(
                table: "MovieWriters",
                keyColumns: new[] { "MovieId", "WriterId" },
                keyValues: new object[] { "tt7220696", "nm0718558" });
        }
    }
}
