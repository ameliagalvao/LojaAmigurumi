using LojaAmigurumi.Models;
using LojaAmigurumi.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAmigurumi.Pages;

public class IndexModel : PageModel
{
    private IPatternService _service;
    public IndexModel(IPatternService patternService)
    {
    _service = patternService;
    }
    public IList<Pattern> ListaPattern { get; private set; }
    public void OnGet()
    {
        ViewData["Title"] = "Home";

        //var servico = new PatternService();
        ListaPattern = _service.ObterTodas();

    }

}
