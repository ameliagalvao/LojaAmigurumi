using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojaAmigurumi.Data;
using LojaAmigurumi.Models;

namespace LojaAmigurumi.Pages_Nivel
{
    public class EditModel : PageModel
    {
        private readonly LojaAmigurumi.Data.PatternDbContext _context;

        public EditModel(LojaAmigurumi.Data.PatternDbContext context)
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

            var nivel =  await _context.Nivel.FirstOrDefaultAsync(m => m.NivelId == id);
            if (nivel == null)
            {
                return NotFound();
            }
            Nivel = nivel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Nivel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NivelExists(Nivel.NivelId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NivelExists(int id)
        {
          return (_context.Nivel?.Any(e => e.NivelId == id)).GetValueOrDefault();
        }
    }
}
