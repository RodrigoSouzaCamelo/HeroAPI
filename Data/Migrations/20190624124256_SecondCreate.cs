using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroAPI.Data.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HeroAPI");

            migrationBuilder.CreateTable(
                name: "Heroes",
                schema: "HeroAPI",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnName = table.Column<string>(type: "varchar(200)", nullable: false),
                    HeroName = table.Column<string>(type: "varchar(200)", nullable: false),
                    Gender = table.Column<string>(type: "enum('Male', 'Female')", nullable: false),
                    Powers = table.Column<string>(type: "varchar(200)", nullable: false),
                    Universe = table.Column<string>(type: "varchar(200)", nullable: false),
                    Team = table.Column<string>(type: "varchar(200)", nullable: false),
                    Classification = table.Column<int>(type: "int(11)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes",
                schema: "HeroAPI");
        }
    }
}
