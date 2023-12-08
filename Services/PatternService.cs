using LojaAmigurumi.Models;

namespace LojaAmigurumi.Services
{
    public class PatternService : IPatternService
    {
        private IList<Pattern> _patterns;

        public PatternService()
            => CarregarListaInicial();

        private void CarregarListaInicial()
        {
            _patterns = new List<Pattern>()
            {
                new Pattern
                {
                    PatternID = 1,
                    PatternName = "Labrador Amigurumi",
                    PatternDescription = "Receita digital em PDF para fazer um cachorrinho da raça Labrador Retriever. Você pode fazê-lo da cor que quiser: amarelo, preto, marrom, etc. Se você quiser também pode transformá-lo num Golden, basta usar a mesma técnica que fiz no Valente.",
                    PatternImageUri = "https://i0.wp.com/www.miahandcrafter.com/atelier/wp-content/uploads/2020/09/labradormiigu.png?resize=300%2C196&ssl=1",
                    PatternPrice = 24.75,
                },
                new Pattern
                {
                    PatternID = 2,
                    PatternName = "Chefe de Cozinha Amigurumi",
                    PatternDescription = "Receita digital em PDF para fazer bonecas chef de cozinha com a opção de escolha entre 2 corpos base (magro e plus size) e de fazer a boneca com as características físicas da síndrome de down ou não.\r\n\r\nElas podem ser articuladas com arame (instruções de como fazer na receita), possuem cabeça articulada no pescoço (vira para os lados) e seus membros são embutidos com crochê.\r\n\r\nInclui também a receita de como fazer o Dolmã, Chapéu de Chef, Rolo de Massa, Tigela, Fouet, Pizza e Bolo Surpresa.",
                    PatternImageUri = "https://i0.wp.com/www.miahandcrafter.com/atelier/wp-content/uploads/2021/07/thum-chef.jpg?resize=300%2C196&ssl=1",
                    PatternPrice = 15.00,
                },
                new Pattern
                {
                    PatternID = 3,
                    PatternName = "Valente Amigurumi",
                    PatternDescription = "Receita digital em PDF para fazer o Valente com braços e penas que se mexem. Ele pode ficar sentado sozinho ou em pé, mas, nesse caso, precisa de apoio. Os seus braços são móveis e podem ficar para baixo ou levantados.",
                    PatternImageUri = "https://i0.wp.com/www.miahandcrafter.com/atelier/wp-content/uploads/2020/09/valent.png?resize=300%2C196&ssl=1",
                    PatternPrice = 29.00,
                }
            };
        }

        public IList<Pattern> ObterTodas()
            => _patterns;

        public Pattern Obter(int id)
        {
            return _patterns.SingleOrDefault(item => item.PatternID == id);
        }

        public void Incluir(Pattern pattern)
        {
            var proximoNumero = _patterns.Max(item =>  item.PatternID) + 1;
            pattern.PatternID = proximoNumero;
            _patterns.Add(pattern);
        }
    }

}
