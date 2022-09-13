
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ThemeContext:DbContext
    {
        public ThemeContext(DbContextOptions<ThemeContext> options):base(options)
        {

        }
        public DbSet<theme> theme { get; set; }
    }
}
