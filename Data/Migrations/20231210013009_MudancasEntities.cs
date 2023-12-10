using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class MudancasEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pattern_Categorias_CategoriaId",
                table: "Pattern");

            migrationBuilder.DropForeignKey(
                name: "FK_Pattern_Nivel_NivelId",
                table: "Pattern");

            migrationBuilder.DropIndex(
                name: "IX_Pattern_CategoriaId",
                table: "Pattern");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Pattern");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Pattern",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ReceitaGratuita",
                table: "Pattern",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.CreateTable(
                name: "CategoriaPattern",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    PatternsPatternId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPattern", x => new { x.CategoriasCategoriaId, x.PatternsPatternId });
                    table.ForeignKey(
                        name: "FK_CategoriaPattern_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPattern_Pattern_PatternsPatternId",
                        column: x => x.PatternsPatternId,
                        principalTable: "Pattern",
                        principalColumn: "PatternId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPattern_PatternsPatternId",
                table: "CategoriaPattern",
                column: "PatternsPatternId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pattern_Nivel_NivelId",
                table: "Pattern",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "NivelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pattern_Nivel_NivelId",
                table: "Pattern");

            migrationBuilder.DropTable(
                name: "CategoriaPattern");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "ReceitaGratuita",
                table: "Pattern");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Pattern",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Pattern",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pattern_CategoriaId",
                table: "Pattern",
                column: "CategoriaId");

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
    }
}
