using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class paymentHistoryInToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentHistory_Movies_MovieId",
                table: "PaymentHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentHistory_AspNetUsers_UserId",
                table: "PaymentHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentHistory",
                table: "PaymentHistory");

            migrationBuilder.RenameTable(
                name: "PaymentHistory",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentHistory_UserId",
                table: "Payments",
                newName: "IX_Payments_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                columns: new[] { "MovieId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Movies_MovieId",
                table: "Payments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Movies_MovieId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "PaymentHistory");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserId",
                table: "PaymentHistory",
                newName: "IX_PaymentHistory_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentHistory",
                table: "PaymentHistory",
                columns: new[] { "MovieId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentHistory_Movies_MovieId",
                table: "PaymentHistory",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentHistory_AspNetUsers_UserId",
                table: "PaymentHistory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
