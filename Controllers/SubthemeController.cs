using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubthemeController : Controller
    {

        private readonly ApplicationDbContext _context;
        public SubthemeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/SubTheme
        [HttpGet]
        public async Task<ActionResult<IEnumerable<subtheme>>> GetSubTheme()
        {
            return await _context.subtheme.ToListAsync();
        }
        [Route("GetsubthemesById/{themeid}")]
        [HttpGet]
        public ActionResult<List<subtheme>> GetStateById(int themeid)
        {
            var stateList = _context.subtheme.Where(a => a.theme.ThemeID == themeid)
                                            .Select(a => new { a.nom });

            return Ok(stateList);

        }
    }
}
