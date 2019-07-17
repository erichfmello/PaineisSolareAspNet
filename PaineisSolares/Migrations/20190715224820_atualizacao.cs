using Microsoft.EntityFrameworkCore.Migrations;

namespace PaineisSolares.Migrations
{
    public partial class atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Ambiente_AmbienteId",
                table: "Equipamento");

            migrationBuilder.AlterColumn<int>(
                name: "AmbienteId",
                table: "Equipamento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Ambiente_AmbienteId",
                table: "Equipamento",
                column: "AmbienteId",
                principalTable: "Ambiente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Ambiente_AmbienteId",
                table: "Equipamento");

            migrationBuilder.AlterColumn<int>(
                name: "AmbienteId",
                table: "Equipamento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Ambiente_AmbienteId",
                table: "Equipamento",
                column: "AmbienteId",
                principalTable: "Ambiente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
