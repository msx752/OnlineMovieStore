using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieStore.Data.Migrations
{
    public partial class fixesProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Director_DirectorId",
                table: "MovieDirector");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Movies_MovieId",
                table: "MovieDirector");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWriter_Movies_MovieId",
                table: "MovieWriter");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWriter_Writer_WriterId",
                table: "MovieWriter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writer",
                table: "Writer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieWriter",
                table: "MovieWriter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Writer");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "Writer",
                newName: "Writers");

            migrationBuilder.RenameTable(
                name: "MovieWriter",
                newName: "MovieWriters");

            migrationBuilder.RenameTable(
                name: "MovieDirector",
                newName: "MovieDirectors");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieWriter_WriterId",
                table: "MovieWriters",
                newName: "IX_MovieWriters_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieWriter_MovieId",
                table: "MovieWriters",
                newName: "IX_MovieWriters_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirector_MovieId",
                table: "MovieDirectors",
                newName: "IX_MovieDirectors_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirector_DirectorId",
                table: "MovieDirectors",
                newName: "IX_MovieDirectors_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieWriters",
                table: "MovieWriters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Directors_DirectorId",
                table: "MovieDirectors",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Movies_MovieId",
                table: "MovieDirectors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWriters_Movies_MovieId",
                table: "MovieWriters",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWriters_Writers_WriterId",
                table: "MovieWriters",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Directors_DirectorId",
                table: "MovieDirectors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Movies_MovieId",
                table: "MovieDirectors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWriters_Movies_MovieId",
                table: "MovieWriters");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWriters_Writers_WriterId",
                table: "MovieWriters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieWriters",
                table: "MovieWriters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.RenameTable(
                name: "Writers",
                newName: "Writer");

            migrationBuilder.RenameTable(
                name: "MovieWriters",
                newName: "MovieWriter");

            migrationBuilder.RenameTable(
                name: "MovieDirectors",
                newName: "MovieDirector");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.RenameIndex(
                name: "IX_MovieWriters_WriterId",
                table: "MovieWriter",
                newName: "IX_MovieWriter_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieWriters_MovieId",
                table: "MovieWriter",
                newName: "IX_MovieWriter_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirectors_MovieId",
                table: "MovieDirector",
                newName: "IX_MovieDirector_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirectors_DirectorId",
                table: "MovieDirector",
                newName: "IX_MovieDirector_DirectorId");

            migrationBuilder.AddColumn<string>(
                name: "MovieId",
                table: "Writer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieId",
                table: "Director",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writer",
                table: "Writer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieWriter",
                table: "MovieWriter",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Director_DirectorId",
                table: "MovieDirector",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Movies_MovieId",
                table: "MovieDirector",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWriter_Movies_MovieId",
                table: "MovieWriter",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWriter_Writer_WriterId",
                table: "MovieWriter",
                column: "WriterId",
                principalTable: "Writer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
