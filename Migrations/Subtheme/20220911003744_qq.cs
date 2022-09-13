using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.Subtheme
{
    public partial class qq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "theme",
                columns: table => new
                {
                    ThemeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theme", x => x.ThemeID);
                });

            migrationBuilder.CreateTable(
                name: "subtheme",
                columns: table => new
                {
                    subthemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subtheme", x => x.subthemeId);
                    table.ForeignKey(
                        name: "FK_subtheme_theme_ThemeID",
                        column: x => x.ThemeID,
                        principalTable: "theme",
                        principalColumn: "ThemeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subtheme_ThemeID",
                table: "subtheme",
                column: "ThemeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subtheme");

            migrationBuilder.DropTable(
                name: "theme");
        }
    }
}
