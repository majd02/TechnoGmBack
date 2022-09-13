using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class subtheme
    {
        [Key]
        public int subthemeId { get; set; }
        public String nom { get; set; }
        public theme theme { get; set; }
    }
}
