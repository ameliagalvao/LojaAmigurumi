using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaAmigurumi.Data;
using LojaAmigurumi.Models;

namespace LojaAmigurumi.Pages_Categoria
{
    public class IndexModel : PageModel
    {
        private readonly LojaAmigurumi.Data.PatternDbContext _context;

        public IndexModel(LojaAmigurumi.Data.PatternDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categoria != null)
            {
                Categoria = await _context.Categoria.ToListAsync();
            }
        }
    }
}
