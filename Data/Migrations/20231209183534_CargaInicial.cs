using LojaAmigurumi.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new PatternDbContext();
            context.Nivel.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }
        private IList<Nivel> ObterCargaInicial()
        {
            return new List<Nivel>()
            {
                new Nivel() {NivelNome = "Iniciante", NivelDescricao = "Anél Mágico, Ponto baixo, aumento e diminuição"},
                new Nivel() {NivelNome = "Intermediário", NivelDescricao = "Além dos requisitos do iniciante, costurar peças"},
                new Nivel() {NivelNome = "Avançado", NivelDescricao = "Além dos resuisitos de iniciante e intermediário, controle de tensão, diferentes tipos de costura, acabamento invisível, troca de cor invisível."}
            };
        }
    }
}
