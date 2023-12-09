namespace LojaAmigurumi.Models
{
    public class Nivel
    {
        public int NivelId { get; set; }

        public string NivelNome { get; set; }
        public string NivelDescricao { get; set; }

        public ICollection<Pattern> Patterns { get; set; }
    }
}
