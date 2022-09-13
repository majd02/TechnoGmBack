﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    { 
        private readonly ThemeContext _context;
        public ThemeController(ThemeContext context)
        {
            _context = context;
        }
        // GET: api/Theme
        [HttpGet]
        public async Task<ActionResult<IEnumerable<theme>>> GetTheme()
        {
            return await _context.theme.ToListAsync();
        }


    }

}
