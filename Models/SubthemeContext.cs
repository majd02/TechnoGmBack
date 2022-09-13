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
    }
}

