using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaineisSolares.Migrations
{
    public partial class CalculoConsumo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    ConsumoUnitario = table.Column<double>(nullable: false),
                    HorasDeUso = table.Column<int>(nullable: false),
                    ConsumoTotal = table.Column<double>(nullable: false),
                    ConsumoTotalPorDia = table.Column<double>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipamento_Ambiente_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipamento_AmbienteId",
                table: "Equipamento",
                column: "AmbienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamento");
        }
    }
}
