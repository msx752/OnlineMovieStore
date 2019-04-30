using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_moviedirectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieDirectors",
                columns: new[] { "MovieId", "DirectorId" },
                values: new object[,]
                {
                    { "tt0054395", "nm0901138" },
                    { "tt0133093", "nm0905152" },
                    { "tt0133093", "nm0905154" },
                    { "tt0234215", "nm0905154" },
                    { "tt0234215", "nm0905152" },
                    { "tt0499549", "nm0000116" },
                    { "tt1517238", "nm0807023" },
                    { "tt1854506", "nm0006955" },
                    { "tt2076307", "nm0956913" },
                    { "tt7220696", "nm0474289" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0054395", "nm0901138" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0133093", "nm0905152" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0133093", "nm0905154" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0234215", "nm0905152" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0234215", "nm0905154" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt0499549", "nm0000116" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt1517238", "nm0807023" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt1854506", "nm0006955" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt2076307", "nm0956913" });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "MovieId", "DirectorId" },
                keyValues: new object[] { "tt7220696", "nm0474289" });
        }
    }
}
