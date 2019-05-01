using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class paymentHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    MovieId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    PaidUsdPrice = table.Column<decimal>(nullable: false),
                    TimeUtc = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistory", x => new { x.MovieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PaymentHistory_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentHistory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_UserId",
                table: "PaymentHistory",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentHistory");
        }
    }
}
