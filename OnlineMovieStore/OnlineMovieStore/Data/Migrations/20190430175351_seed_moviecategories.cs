using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_moviecategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieId", "CategoryId" },
                values: new object[,]
                {
                    { "tt0133093", 1 },
                    { "tt7220696", 6 },
                    { "tt6933454", 6 },
                    { "tt3492330", 12 },
                    { "tt3492330", 5 },
                    { "tt2076307", 13 },
                    { "tt2076307", 7 },
                    { "tt2076307", 6 },
                    { "tt1517238", 6 },
                    { "tt0870915", 12 },
                    { "tt0870915", 11 },
                    { "tt0091805", 12 },
                    { "tt0091805", 11 },
                    { "tt0091805", 1 },
                    { "tt7640234", 5 },
                    { "tt7220696", 14 },
                    { "tt7640234", 6 },
                    { "tt7578416", 11 },
                    { "tt0054395", 8 },
                    { "tt0054395", 5 },
                    { "tt0054395", 11 },
                    { "tt9024440", 5 },
                    { "tt9024440", 7 },
                    { "tt9024440", 10 },
                    { "tt8968844", 5 },
                    { "tt1854506", 5 },
                    { "tt1775309", 5 },
                    { "tt0499549", 4 },
                    { "tt0499549", 3 },
                    { "tt0499549", 1 },
                    { "tt0234215", 1 },
                    { "tt7640234", 3 },
                    { "tt7220696", 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0054395", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0054395", 8 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0054395", 11 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0091805", 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0091805", 11 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0091805", 12 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0133093", 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0234215", 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0499549", 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0499549", 3 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0499549", 4 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0870915", 11 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt0870915", 12 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt1517238", 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt1775309", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt1854506", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt2076307", 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt2076307", 7 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt2076307", 13 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt3492330", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt3492330", 12 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt6933454", 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7220696", 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7220696", 14 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7220696", 15 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7578416", 11 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7640234", 3 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7640234", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt7640234", 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt8968844", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt9024440", 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt9024440", 7 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "MovieId", "CategoryId" },
                keyValues: new object[] { "tt9024440", 10 });
        }
    }
}
