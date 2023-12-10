using LojaAmigurumi.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicialForPattern : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new PatternDbContext();
            context.Pattern.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }
        private IList<Pattern> ObterCargaInicial()
        {
            return new List<Pattern>()
            {
                new Pattern() { PatternName = "Labrador Retriever Amigurumi", PatternDescription = "Receita digital em PDF para fazer um cachorrinho da raça Labrador Retriever.", PatternImageUri = "images/labradormiigu.jpg", PatternPrice = 24.75, ReceitaGratuita = false },
                new Pattern() { PatternName = "Chefs de Cozinha Amigurumi", PatternDescription = "Receita digital em PDF para bonecas chef de cozinha com duas opções de corpos.", PatternImageUri = "images/thm-chef.jpg", PatternPrice = 15.00, ReceitaGratuita = false },
                new Pattern() { PatternName = "R2D2 Amigurumi", PatternDescription = "Receita digital para fazer o droid R2D2 com a opção de usar LEDs.", PatternImageUri = "images/r2d2", PatternPrice = 0.00, ReceitaGratuita = true },
            };
        }
    }
}
