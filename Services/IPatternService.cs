namespace LojaAmigurumi.Services
{
    public interface IPatternService
    {
        IList<Models.Pattern> ObterTodas();
        Models.Pattern Obter(int id);
        void Incluir(Models.Pattern pattern);

    }
}
