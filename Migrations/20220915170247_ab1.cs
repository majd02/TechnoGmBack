using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class ab1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "subtheme",
                columns: new[] { "subthemeId", "ThemeID", "nom" },
                values: new object[,]
                {
                    { 2, 1, "Hicking" },
                    { 14, 1, "Activité plein air" },
                    { 13, 1, "plante et agriculture" },
                    { 12, 1, "Nature and ecology tour" },
                    { 10, 1, "Night sky" },
                    { 9, 1, "Back packing" },
                    { 11, 1, "Back packing" },
                    { 7, 1, "sand diving" },
                    { 6, 1, "fishing" },
                    { 5, 1, "hunt" },
                    { 4, 1, "walking" },
                    { 3, 1, "Prepare meals in nature" },
                    { 8, 1, "Ski Palmier" }
                });

            migrationBuilder.InsertData(
                table: "theme",
                columns: new[] { "ThemeID", "name" },
                values: new object[,]
                {
                    { 6, "seaside" },
                    { 2, "health" },
                    { 3, "food" },
                    { 4, "event" },
                    { 5, "culture" },
                    { 7, "autres" }
                });

            migrationBuilder.InsertData(
                table: "subtheme",
                columns: new[] { "subthemeId", "ThemeID", "nom" },
                values: new object[,]
                {
                    { 15, 2, "Beauté" },
                    { 42, 5, " Festival Culturelle" },
                    { 43, 5, " Mariage traditionnelle" },
                    { 44, 5, "tatouage traditionnelle " },
                    { 45, 5, " Vivre une experience avec une famille" },
                    { 46, 6, "SeaDiving" },
                    { 47, 6, "Parachute" },
                    { 48, 6, " Location pédale a eau/bateau" },
                    { 49, 6, "Snorking" },
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
                    { 41, 5, "visite de bureau" },
                    { 40, 5, "Visite culturelle " },
                    { 39, 5, "Danse culturelle" },
                    { 38, 5, "conférence sur des enjeux sociaux" },
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
                    { 63, 7, "gambling" },
                    { 26, 3, "diner en groupe" },
                    { 28, 4, "sport" },
                    { 29, 4, "sycling" },
                    { 30, 4, "Divertissement" },
                    { 31, 5, "Cours sur l’entrepreneuriat" }
                });

            migrationBuilder.InsertData(
                table: "subtheme",
                columns: new[] { "subthemeId", "ThemeID", "nom" },
                values: new object[,]
                {
                    { 32, 5, "Conférence culturelle" },
                    { 33, 5, "Cours de langue " },
                    { 34, 5, " Visite d’usine" },
                    { 35, 5, "Visite de campagne " },
                    { 36, 5, " Autre activité culturelle" },
                    { 37, 5, " Cours de sciences " },
                    { 27, 3, "Visite de marché et gastronomie" },
                    { 64, 7, "tour de bar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "subtheme",
                keyColumn: "subthemeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "theme",
                keyColumn: "ThemeID",
                keyValue: 7);
        }
    }
}
