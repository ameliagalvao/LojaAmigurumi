using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LojaAmigurumi.Data;
using LojaAmigurumi.Models;
using Microsoft.AspNetCore.Authorization;

namespace LojaAmigurumi.Pages_Niveis
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly LojaAmigurumi.Data.PatternDbContext _context;

        public CreateModel(LojaAmigurumi.Data.PatternDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Nivel Nivel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Nivel == null || Nivel == null)
            {
                return Page();
            }

            _context.Nivel.Add(Nivel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
