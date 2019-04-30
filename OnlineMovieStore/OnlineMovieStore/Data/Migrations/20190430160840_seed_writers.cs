using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class seed_writers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { "nm0908624", "Edgar Wallace" },
                    { "nm0251912", "Egon Eis" },
                    { "nm0525742", "Wolfgang Lukschy" },
                    { "nm0173775", "Lluís Josep Comerón" },
                    { "nm0905152", "Lilly Wachowski" },
                    { "nm0905154", "Lana Wachowski" },
                    { "nm0000116", "James Cameron" },
                    { "nm0807023", "Natalia Smirnoff" },
                    { "nm0150043", "Ted Chalmers" },
                    { "nm0827500", "David S. Sterling" },
                    { "nm0956913", "Andrei Zinca" },
                    { "nm0610219", "Oren Moverman" },
                    { "nm0474289", "Heikki Kujanpää" },
                    { "nm0718558", "Mikko Reitala" },
                    { "nm10086396", "Bradley Alcime" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0000116");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0150043");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0173775");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0251912");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0474289");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0525742");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0610219");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0718558");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0807023");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0827500");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0905152");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0905154");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0908624");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm0956913");

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: "nm10086396");
        }
    }
}
