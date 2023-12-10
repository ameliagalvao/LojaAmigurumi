using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaAmigurumi.Data;
using LojaAmigurumi.Models;

namespace LojaAmigurumi.Pages_Niveis
{
    public class DetailsModel : PageModel
    {
        private readonly LojaAmigurumi.Data.PatternDbContext _context;

        public DetailsModel(LojaAmigurumi.Data.PatternDbContext context)
        {
            _context = context;
        }

      public Nivel Nivel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Nivel == null)
            {
                return NotFound();
            }

            var nivel = await _context.Nivel.FirstOrDefaultAsync(m => m.NivelId == id);
            if (nivel == null)
            {
                return NotFound();
            }
            else 
            {
                Nivel = nivel;
            }
            return Page();
        }
    }
}
