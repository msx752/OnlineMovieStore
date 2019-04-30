using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_directors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { "nm0901138", "Alfred Vohrer" },
                    { "nm0173775", "Lluís Josep Comerón" },
                    { "nm0905152", "Lilly Wachowski" },
                    { "nm0905154", "Lana Wachowski" },
                    { "nm0000116", "James Cameron" },
                    { "nm0807023", "Natalia Smirnoff" },
                    { "nm0006955", "Lewis Schoenbrun" },
                    { "nm0956913", "Andrei Zinca" },
                    { "nm0474289", "Heikki Kujanpää" },
                    { "nm10086396", "Bradley Alcime" },
                    { "nm10114969", "Ahmed Mansour" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0000116");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0006955");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0173775");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0474289");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0807023");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0901138");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0905152");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0905154");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm0956913");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm10086396");

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: "nm10114969");
        }
    }
}
