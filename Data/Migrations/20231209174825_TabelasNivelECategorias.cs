using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelasNivelECategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Pattern",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Pattern",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    NivelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.NivelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pattern_CategoriaId",
                table: "Pattern",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pattern_NivelId",
                table: "Pattern",
                column: "NivelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pattern_Categorias_CategoriaId",
                table: "Pattern",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pattern_Nivel_NivelId",
                table: "Pattern",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "NivelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pattern_Categorias_CategoriaId",
                table: "Pattern");

            migrationBuilder.DropForeignKey(
                name: "FK_Pattern_Nivel_NivelId",
                table: "Pattern");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropIndex(
                name: "IX_Pattern_CategoriaId",
                table: "Pattern");

            migrationBuilder.DropIndex(
                name: "IX_Pattern_NivelId",
                table: "Pattern");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Pattern");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Pattern");
        }
    }
}
