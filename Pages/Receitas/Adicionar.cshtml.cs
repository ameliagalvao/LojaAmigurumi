using LojaAmigurumi.Models;
using LojaAmigurumi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaAmigurumi.Pages.Receitas
{
    public class AdicionarModel : PageModel
    {
        public SelectList NivelOptionItems { get; set; }
        private IPatternService _service;
        public AdicionarModel(IPatternService patternService)
        {
            _service = patternService;
        }

        public void OnGet()
        {
            NivelOptionItems = new SelectList(_service.ObterTodosNiveis(),
                                                nameof(Nivel.NivelId),
                                                nameof(Nivel.NivelNome),
                                                nameof(Nivel.NivelDescricao));
        }

        [BindProperty]
        public Pattern Pattern { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _service.Incluir(Pattern);
            return RedirectToPage("/Index");
        }
    }
}
