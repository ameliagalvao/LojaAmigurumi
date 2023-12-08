using LojaAmigurumi.Models;
using LojaAmigurumi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAmigurumi.Pages
{
    public class AdicionarModel : PageModel
    {
        private IPatternService _service;
        public AdicionarModel(IPatternService patternService)
        {
            _service = patternService;
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
