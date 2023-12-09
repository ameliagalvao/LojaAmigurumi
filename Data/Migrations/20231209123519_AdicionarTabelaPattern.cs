using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaPattern : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pattern",
                columns: table => new
                {
                    PatternId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatternName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PatternDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PatternImageUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatternPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pattern", x => x.PatternId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pattern");
        }
    }
}
