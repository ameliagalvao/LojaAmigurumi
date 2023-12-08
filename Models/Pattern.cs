using System.ComponentModel.DataAnnotations;

namespace LojaAmigurumi.Models
{
    public class Pattern
    {
        public int PatternID { get; set; }
        public string PatternName { get; set; }
        public string PatternSlug => PatternName.ToLower().Replace(" ", "-");
        public string PatternDescription { get; set; }
        public string PatternImageUri { get; set; }
        public double PatternPrice { get; set; }

    }
}
