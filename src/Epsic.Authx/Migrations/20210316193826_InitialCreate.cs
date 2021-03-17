using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Epsic.Authx.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestsCovid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateTest = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Resultat = table.Column<bool>(type: "INTEGER", nullable: false),
                    TypeDeTest = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestsCovid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestsCovid");
        }
    }
}
