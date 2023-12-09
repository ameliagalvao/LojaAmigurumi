namespace LojaAmigurumi.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public ICollection<Pattern>? Patterns { get; set; }
    }
}
