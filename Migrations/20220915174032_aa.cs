using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class aa : Migration
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
                    ThemeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subtheme", x => x.subthemeId);
                    table.ForeignKey(
                        name: "FK_subtheme_theme_ThemeID",
                        column: x => x.ThemeID,
                        principalTable: "theme",
                        principalColumn: "ThemeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "theme",
                columns: new[] { "ThemeID", "name" },
                values: new object[,]
                {
                    { 1, "nature" },
                    { 2, "health" },
                    { 3, "food" },
                    { 4, "event" },
                    { 5, "culture" },
                    { 6, "seaside" },
                    { 7, "autres" }
                });

            migrationBuilder.InsertData(
                table: "subtheme",
                columns: new[] { "subthemeId", "ThemeID", "nom" },
                values: new object[,]
                {
                    { 1, 1, "Camping" },
                    { 35, 5, "Visite de campagne " },
                    { 36, 5, " Autre activité culturelle" },
                    { 37, 5, " Cours de sciences " },
                    { 38, 5, "conférence sur des enjeux sociaux" },
                    { 39, 5, "Danse culturelle" },
                    { 40, 5, "Visite culturelle " },
                    { 41, 5, "visite de bureau" },
                    { 42, 5, " Festival Culturelle" },
                    { 43, 5, " Mariage traditionnelle" },
                    { 44, 5, "tatouage traditionnelle " },
                    { 45, 5, " Vivre une experience avec une famille" },
                    { 46, 6, "SeaDiving" },
                    { 47, 6, "Parachute" },
                    { 34, 5, " Visite d’usine" },
                    { 48, 6, " Location pédale a eau/bateau" },
                    { 50, 6, " Bataille d’eau " },
                    { 51, 6, "Apprendre à nager" },
                    { 52, 6, "sport nautrique" },
                    { 53, 6, "chercher des coquillages " },
                    { 54, 6, "Bâtir des châteaux de sable" },
                    { 55, 6, "S’enterrer dans les sables" },
                    { 56, 6, "Morpion dans le sable" },
                    { 57, 6, "découvrir le chair à voile " },
                    { 58, 6, "Jeux de ballon" },
                    { 59, 7, "Jetski" },
                    { 60, 7, "shooping" },
                    { 61, 7, "boisson" },
                    { 62, 7, "animaux" },
                    { 49, 6, "Snorking" },
                    { 33, 5, "Cours de langue " },
                    { 32, 5, "Conférence culturelle" },
                    { 31, 5, "Cours sur l’entrepreneuriat" },
                    { 2, 1, "Hicking" },
                    { 3, 1, "Prepare meals in nature" },
                    { 4, 1, "walking" },
                    { 5, 1, "hunt" },
                    { 6, 1, "fishing" },
                    { 7, 1, "sand diving" },
                    { 8, 1, "Ski Palmier" },
                    { 9, 1, "Back packing" },
                    { 10, 1, "Night sky" }
                });

            migrationBuilder.InsertData(
                table: "subtheme",
                columns: new[] { "subthemeId", "ThemeID", "nom" },
                values: new object[,]
                {
                    { 11, 1, "Back packing" },
                    { 12, 1, "Nature and ecology tour" },
                    { 13, 1, "plante et agriculture" },
                    { 14, 1, "Activité plein air" },
                    { 15, 2, "Beauté" },
                    { 16, 2, "spa" },
                    { 17, 2, "pleine conscience" },
                    { 18, 2, "thérapie de corps" },
                    { 19, 2, "Etat d’esprit" },
                    { 20, 2, "Yoga" },
                    { 21, 2, "santé holistique" },
                    { 22, 2, "Divination" },
                    { 23, 2, "Autre Expérience Bien-être" },
                    { 24, 3, "cuisineet alimentation" },
                    { 25, 3, "degustation gastronomique" },
                    { 26, 3, "diner en groupe" },
                    { 27, 3, "Visite de marché et gastronomie" },
                    { 28, 4, "sport" },
                    { 29, 4, "sycling" },
                    { 30, 4, "Divertissement" },
                    { 63, 7, "gambling" },
                    { 64, 7, "tour de bar" }
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
