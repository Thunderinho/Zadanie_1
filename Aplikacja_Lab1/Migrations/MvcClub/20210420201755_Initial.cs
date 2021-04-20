using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_Lab1.Migrations.MvcClub
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Club_Name = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Nationality = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Club");
        }
    }
}
