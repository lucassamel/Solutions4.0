using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Solutions4.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Regiao = table.Column<string>(nullable: true),
                    DataDeposito = table.Column<DateTime>(nullable: false),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    DataEntradaNacional = table.Column<DateTime>(nullable: false),
                    PaisPrioridade = table.Column<string>(nullable: true),
                    NumeroPrioridade = table.Column<int>(nullable: false),
                    DataPrioridade = table.Column<DateTime>(nullable: false),
                    ClassificacaoIPC = table.Column<string>(nullable: true),
                    Depositante = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    Procurador = table.Column<string>(nullable: true),
                    RPI = table.Column<int>(nullable: false),
                    DataRPI = table.Column<DateTime>(nullable: false),
                    Despacho = table.Column<int>(nullable: false),
                    DescricaoDespacho = table.Column<string>(nullable: true),
                    ComplementoDespacho = table.Column<string>(nullable: true),
                    NumeroPacote = table.Column<int>(nullable: false),
                    DataPacote = table.Column<DateTime>(nullable: false),
                    CodigoWO = table.Column<string>(nullable: true),
                    DataWO = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patentes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patentes");
        }
    }
}
