using LojaAmigurumi.Models;
using LojaAmigurumi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAmigurumi.Pages.Receitas
{
    public class DetailsModel : PageModel
    {
        private IPatternService _service;
        public DetailsModel(IPatternService patternService) {
            _service = patternService;
        }
        public Pattern Pattern { get; private set; }
        public Nivel Nivel { get; private set; }

        public IActionResult OnGet(int id)
        {
            Pattern = _service.Obter(id);
            Nivel = _service.ObterTodosNiveis().SingleOrDefault(item => item.NivelId == Pattern.NivelId);

            if (Pattern == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
        
}
