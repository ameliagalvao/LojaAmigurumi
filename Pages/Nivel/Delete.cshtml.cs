using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaAmigurumi.Data;
using LojaAmigurumi.Models;

namespace LojaAmigurumi.Pages_Nivel
{
    public class DeleteModel : PageModel
    {
        private readonly LojaAmigurumi.Data.PatternDbContext _context;

        public DeleteModel(LojaAmigurumi.Data.PatternDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Nivel == null)
            {
                return NotFound();
            }
            var nivel = await _context.Nivel.FindAsync(id);

            if (nivel != null)
            {
                Nivel = nivel;
                _context.Nivel.Remove(Nivel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
