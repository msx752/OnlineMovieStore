using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class movie_price_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UsdPrice",
                table: "Movies",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsdPrice",
                table: "Movies");
        }
    }
}
