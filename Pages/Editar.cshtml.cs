using LojaAmigurumi.Models;
using LojaAmigurumi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAmigurumi.Pages
{
    public class EditarModel : PageModel
    {

        private IPatternService _service;
        public EditarModel(IPatternService patternService)
        {
            _service = patternService;
        }

        [BindProperty]
        public Pattern Pattern { get; set; }
        public void OnGet(int id)
            => Pattern = _service.Obter(id);
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
