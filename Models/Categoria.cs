namespace LojaAmigurumi.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaDescricao { get; set; }
        public ICollection<Pattern>? Patterns { get; set; }
    }
}
