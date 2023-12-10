using LojaAmigurumi.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicialCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new PatternDbContext();
            context.Categoria.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }
        private IList<Categoria> ObterCargaInicial()
        {
            return new List<Categoria>()
            {
                new Categoria() {CategoriaNome = "Cachorros"},
                new Categoria() {CategoriaNome = "Personagens"},
                new Categoria() {CategoriaNome = "Humanos"}
            };
        }

    }
}
