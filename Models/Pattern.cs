using System.ComponentModel.DataAnnotations;

namespace LojaAmigurumi.Models
{
    public class Pattern
    {
        public int PatternId { get; set; }

        [Display(Name = "Nome da Receita")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Nome' obrigatório.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve conter entre 10 e 50 caracteres.")]
        public string PatternName { get; set; }

        public string PatternSlug => PatternName.ToLower().Replace(" ", "-");

        [Display(Name = "Descrição")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Descrição' obrigatório.")]
        [StringLength(100, MinimumLength = 50, ErrorMessage = "Campo 'Descrição' deve conter entre 50 e 100 caracteres.")]
        public string PatternDescription { get; set; }

        [Display(Name = "Caminho da Imagem")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Caminho da Image' obrigatório.")]
        public string PatternImageUri { get; set; }

        //[Display(Name = "Receita Gratuita?")]
        //public bool ReceitaGratuita { get; set; }

        //public string ReceitaGratuitaFormatada => ReceitaGratuita ? "Sim" : "Não";

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [DataType(DataType.Currency)]
        public double PatternPrice { get; set; }

        [Display(Name = "Nivel de Dificuldade")]
        [Required(ErrorMessage = "Campo 'Nivel de Dificuldade' obrigatório.")]
        public int NivelId { get; set; }

    }
}
