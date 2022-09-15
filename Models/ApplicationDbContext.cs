
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp.Models;

namespace TestApiJWT.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<subtheme> subtheme { get; set; }

        public DbSet<theme> theme { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<theme>().ToTable("theme");

            modelBuilder.Entity<subtheme>().ToTable("subtheme");
            modelBuilder.Entity<subtheme>()
           .HasOne(p => p.theme)
           .WithMany(b => b.themes)
           .HasForeignKey(p => p.ThemeID);
            modelBuilder.Entity<subtheme>().HasData(
           new List<subtheme> {
                 new subtheme{subthemeId=1, nom="Camping",ThemeID=1   } ,new subtheme{subthemeId=2,nom="Hicking",ThemeID=1}
                 ,new subtheme{subthemeId=3,nom="Prepare meals in nature",ThemeID=1}
                 ,new subtheme{subthemeId=4,nom="walking",ThemeID=1}
                 ,new subtheme{subthemeId=5,nom="hunt",ThemeID=1}
                 ,new subtheme{subthemeId=6,nom="fishing",ThemeID=1}
                 ,new subtheme{subthemeId=7,nom="sand diving",ThemeID=1}
                 ,new subtheme{subthemeId=8,nom="Ski Palmier",ThemeID=1}
                 ,new subtheme{subthemeId=9,nom="Back packing",ThemeID=1}
                 ,new subtheme{subthemeId=10,nom="Night sky",ThemeID=1}
                 ,new subtheme{subthemeId=11,nom="Back packing",ThemeID=1}
                 ,new subtheme{subthemeId=12,nom="Nature and ecology tour",ThemeID=1}

                 ,new subtheme{subthemeId=13,nom="plante et agriculture",ThemeID=1}




                 ,new subtheme{subthemeId=14,nom="Activité plein air",ThemeID=1}


                 ,new subtheme{subthemeId=15,nom="Beauté",ThemeID=2}
                 ,new subtheme{subthemeId=16,nom="spa",ThemeID=2}
                 ,new subtheme{subthemeId=17,nom="pleine conscience",ThemeID=2}
                 ,new subtheme{subthemeId=18,nom="thérapie de corps",ThemeID=2}
                 ,new subtheme{subthemeId=19,nom="Etat d’esprit",ThemeID=2}
                 ,new subtheme{subthemeId=20,nom="Yoga",ThemeID=2}
                 ,new subtheme{subthemeId=21,nom="santé holistique",ThemeID=2}
                 ,new subtheme{subthemeId=22,nom="Divination",ThemeID=2}
                 ,new subtheme{subthemeId=23,nom="Autre Expérience Bien-être",ThemeID=2}

                 ,new subtheme{subthemeId=24,nom="cuisineet alimentation",ThemeID=3}

                 ,new subtheme{subthemeId=25,nom="degustation gastronomique",ThemeID=3}
                 ,new subtheme{subthemeId=26,nom="diner en groupe",ThemeID=3}
                 ,new subtheme{subthemeId=27,nom="Visite de marché et gastronomie",ThemeID=3}
                 ,new subtheme{subthemeId=28,nom="sport",ThemeID=4}



                 ,new subtheme{subthemeId=29,nom="sycling",ThemeID=4}
                 ,new subtheme{subthemeId=30,nom="Divertissement",ThemeID=4}
                 ,new subtheme{subthemeId=31,nom="Cours sur l’entrepreneuriat",ThemeID=5}
                 ,new subtheme{subthemeId=32,nom="Conférence culturelle",ThemeID=5}
                 ,new subtheme{subthemeId=33,nom="Cours de langue ",ThemeID=5}
                 ,new subtheme{subthemeId=34,nom=" Visite d’usine",ThemeID=5}
                 ,new subtheme{subthemeId=35,nom="Visite de campagne ",ThemeID=5}
                 ,new subtheme{subthemeId=36,nom=" Autre activité culturelle",ThemeID=5}
                 ,new subtheme{subthemeId=37,nom=" Cours de sciences ",ThemeID=5}
                 ,new subtheme{subthemeId=38,nom="conférence sur des enjeux sociaux",ThemeID=5}
                 ,new subtheme{subthemeId=39,nom="Danse culturelle",ThemeID=5}
                 ,new subtheme{subthemeId=40,nom="Visite culturelle ",ThemeID=5}
                 ,new subtheme{subthemeId=41,nom="visite de bureau",ThemeID=5}
                 ,new subtheme{subthemeId=42,nom=" Festival Culturelle",ThemeID=5}
                 ,new subtheme{subthemeId=43,nom=" Mariage traditionnelle",ThemeID=5}
                 ,new subtheme{subthemeId=44,nom="tatouage traditionnelle ",ThemeID=5}
                 ,new subtheme{subthemeId=45,nom=" Vivre une experience avec une famille",ThemeID=5}
                 ,new subtheme{subthemeId=46,nom="SeaDiving",ThemeID=6}
                 ,new subtheme{subthemeId=47,nom="Parachute",ThemeID=6}
                 ,new subtheme{subthemeId=48,nom=" Location pédale a eau/bateau",ThemeID=6}
                 ,new subtheme{subthemeId=49,nom="Snorking",ThemeID=6}
                 ,new subtheme{subthemeId=50,nom=" Bataille d’eau ",ThemeID=6}
                 ,new subtheme{subthemeId=51,nom="Apprendre à nager",ThemeID=6}
                 ,new subtheme{subthemeId=52,nom="sport nautrique",ThemeID=6}
                 ,new subtheme{subthemeId=53,nom="chercher des coquillages ",ThemeID=6}
                 ,new subtheme{subthemeId=54,nom="Bâtir des châteaux de sable",ThemeID=6}
                 ,new subtheme{subthemeId=55,nom="S’enterrer dans les sables",ThemeID=6}
                 ,new subtheme{subthemeId=56,nom="Morpion dans le sable",ThemeID=6}
                 ,new subtheme{subthemeId=57,nom="découvrir le chair à voile ",ThemeID=6}
                 ,new subtheme{subthemeId=58,nom="Jeux de ballon",ThemeID=6}
                 ,new subtheme{subthemeId=59,nom="Jetski",ThemeID=7}

                 ,new subtheme{subthemeId=60,nom="shooping",ThemeID=7}

                 ,new subtheme{subthemeId=61,nom="boisson",ThemeID=7}
                 ,new subtheme{subthemeId=62,nom="animaux",ThemeID=7}
                 ,new subtheme{subthemeId=63,nom="gambling",ThemeID=7}
                 ,new subtheme{subthemeId=64,nom="tour de bar",ThemeID=7}

            });

            modelBuilder.Entity<theme>().HasData(new List<theme> {
                 new theme{ThemeID=1,name="nature"},new theme{ThemeID=2,name="health"},new theme{ThemeID=3,name="food"},new theme{ThemeID=4,name="event"}
                 ,new theme{ThemeID=5,name="culture"},new theme{ThemeID=6,name="seaside"},new theme{ThemeID=7,name="autres"}
             });
        }

    }
}