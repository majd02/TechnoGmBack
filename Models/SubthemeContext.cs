using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SubthemeContext:DbContext
    {
        public SubthemeContext(DbContextOptions<SubthemeContext> options) : base(options)
        {

        }
        public DbSet<subtheme> subtheme { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<subtheme>().HasData(
            new List<subtheme> {
                 new subtheme{subthemeId=1, nom="Camping"   } ,new subtheme{subthemeId=2,nom="Hicking"}
                 ,new subtheme{subthemeId=3,nom="Prepare meals in nature"}
                 ,new subtheme{subthemeId=4,nom="walking"}
                 ,new subtheme{subthemeId=5,nom="hunt"}
                 ,new subtheme{subthemeId=6,nom="fishing"}
                 ,new subtheme{subthemeId=7,nom="sand diving"}
                 ,new subtheme{subthemeId=8,nom="Ski Palmier"}
                 ,new subtheme{subthemeId=9,nom="Back packing"}
                 ,new subtheme{subthemeId=10,nom="Night sky"}
                 ,new subtheme{subthemeId=11,nom="Back packing"}
                 ,new subtheme{subthemeId=12,nom="Nature and ecology tour"}

                 ,new subtheme{subthemeId=13,nom="plante et agriculture"}




                 ,new subtheme{subthemeId=14,nom="Activité plein air"}
               

                 ,new subtheme{subthemeId=15,nom="Beauté"}
                 ,new subtheme{subthemeId=16,nom="spa"}
                 ,new subtheme{subthemeId=17,nom="pleine conscience"}
                 ,new subtheme{subthemeId=18,nom="thérapie de corps"}
                 ,new subtheme{subthemeId=19,nom="Etat d’esprit"}
                 ,new subtheme{subthemeId=20,nom="Yoga"}
                 ,new subtheme{subthemeId=21,nom="santé holistique"}
                 ,new subtheme{subthemeId=22,nom="Divination"}
                 ,new subtheme{subthemeId=23,nom="Autre Expérience Bien-être"}

                 ,new subtheme{subthemeId=24,nom="cuisineet alimentation"}

                 ,new subtheme{subthemeId=25,nom="degustation gastronomique"}
                 ,new subtheme{subthemeId=26,nom="diner en groupe"}
                 ,new subtheme{subthemeId=27,nom="Visite de marché et gastronomie"}
                 ,new subtheme{subthemeId=28,nom="sport"}



                 ,new subtheme{subthemeId=29,nom="sycling"}
                 ,new subtheme{subthemeId=30,nom="Divertissement"}
                 ,new subtheme{subthemeId=31,nom="Cours sur l’entrepreneuriat"}
                 ,new subtheme{subthemeId=32,nom="Conférence culturelle"}
                 ,new subtheme{subthemeId=33,nom="Cours de langue "}
                 ,new subtheme{subthemeId=34,nom=" Visite d’usine"}
                 ,new subtheme{subthemeId=35,nom="Visite de campagne "}
                 ,new subtheme{subthemeId=36,nom=" Autre activité culturelle"}
                 ,new subtheme{subthemeId=37,nom=" Cours de sciences "}
                 ,new subtheme{subthemeId=38,nom="conférence sur des enjeux sociaux"}
                 ,new subtheme{subthemeId=39,nom="Danse culturelle"}
                 ,new subtheme{subthemeId=40,nom="Visite culturelle "}
                 ,new subtheme{subthemeId=41,nom="visite de bureau"}
                 ,new subtheme{subthemeId=42,nom=" Festival Culturelle"}
                 ,new subtheme{subthemeId=43,nom=" Mariage traditionnelle"}
                 ,new subtheme{subthemeId=44,nom="tatouage traditionnelle "}
                 ,new subtheme{subthemeId=45,nom=" Vivre une experience avec une famille"}
                 ,new subtheme{subthemeId=46,nom="SeaDiving"}
                 ,new subtheme{subthemeId=47,nom="Parachute"}
                 ,new subtheme{subthemeId=48,nom=" Location pédale a eau/bateau"}
                 ,new subtheme{subthemeId=49,nom="Snorking"}
                 ,new subtheme{subthemeId=50,nom=" Bataille d’eau "}
                 ,new subtheme{subthemeId=51,nom="Apprendre à nager"}
                 ,new subtheme{subthemeId=52,nom="sport nautrique"}
                 ,new subtheme{subthemeId=53,nom="chercher des coquillages "}
                 ,new subtheme{subthemeId=54,nom="Bâtir des châteaux de sable"}
                 ,new subtheme{subthemeId=55,nom="S’enterrer dans les sables"}
                 ,new subtheme{subthemeId=56,nom="Morpion dans le sable"}
                 ,new subtheme{subthemeId=57,nom="découvrir le chair à voile "}
                 ,new subtheme{subthemeId=58,nom="Jeux de ballon"}
                 ,new subtheme{subthemeId=59,nom="Jetski"}

                 ,new subtheme{subthemeId=60,nom="shooping"}

                 ,new subtheme{subthemeId=61,nom="boisson"}
                 ,new subtheme{subthemeId=62,nom="animaux"}
                 ,new subtheme{subthemeId=63,nom="gambling"}
                 ,new subtheme{subthemeId=64,nom="tour de bar"}

             });
            
            modelBuilder.Entity<theme>().HasData(new List<theme> {
                 new theme{ThemeID=1,name="nature"},new theme{ThemeID=2,name="health"},new theme{ThemeID=3,name="food"},new theme{ThemeID=4,name="event"}
                 ,new theme{ThemeID=5,name="culture"},new theme{ThemeID=6,name="seaside"},new theme{ThemeID=7,name="autres"}
             });

        }

    }
}

