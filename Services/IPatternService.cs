using LojaAmigurumi.Models;

namespace LojaAmigurumi.Services
{
    public interface IPatternService
    {
        IList<Models.Pattern> ObterTodas();
        Models.Pattern Obter(int id);
        void Incluir(Models.Pattern pattern);

        void Alterar(Models.Pattern pattern);

        void Excluir(int id);

        IList<Nivel> ObterTodosNiveis();
        IList<Categoria> ObterTodasCategorias();

    }
}
