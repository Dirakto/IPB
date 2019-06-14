using Microsoft.EntityFrameworkCore.Migrations;

namespace ipb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Title = table.Column<string>(nullable: true),
                    GraczName = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Kategoria = table.Column<int>(nullable: false),
                    Stan = table.Column<int>(nullable: false),
                    CzyPowazny = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listy");
        }
    }
}
