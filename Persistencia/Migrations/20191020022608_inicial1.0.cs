using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class inicial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONTATOS",
                columns: table => new
                {
                    ContatoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroTelefone = table.Column<long>(nullable: false),
                    Empresa = table.Column<string>(nullable: true),
                    Obscervacao = table.Column<string>(nullable: true),
                    TipoServico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTATOS", x => x.ContatoId);
                });

            migrationBuilder.CreateTable(
                name: "OCORRENCIAS",
                columns: table => new
                {
                    OcorrenciaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroOcorrencia = table.Column<long>(nullable: true),
                    Titulo = table.Column<string>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    StatusOcorrencia = table.Column<int>(nullable: false),
                    CriticidadeOcorrencia = table.Column<int>(nullable: false),
                    Solucao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCORRENCIAS", x => x.OcorrenciaId);
                });

            migrationBuilder.CreateTable(
                name: "ROTINAS",
                columns: table => new
                {
                    RotinaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    OrdemDeServico = table.Column<int>(nullable: false),
                    Execucao = table.Column<int>(nullable: false),
                    ResponsavelDaRotina = table.Column<string>(nullable: true),
                    Assinatura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROTINAS", x => x.RotinaId);
                });

            migrationBuilder.CreateTable(
                name: "ITERACOES_OCORRENCIAS",
                columns: table => new
                {
                    IteracaoOcorrenciaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TextoIteracao = table.Column<string>(nullable: true),
                    DataHoraIteracao = table.Column<DateTime>(nullable: false),
                    Assinatura = table.Column<string>(nullable: true),
                    OcorrenciaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITERACOES_OCORRENCIAS", x => x.IteracaoOcorrenciaId);
                    table.ForeignKey(
                        name: "FK_ITERACOES_OCORRENCIAS_OCORRENCIAS_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "OCORRENCIAS",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVIDORES",
                columns: table => new
                {
                    ServidorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    AmbienteServidor = table.Column<int>(nullable: false),
                    ServidorIp = table.Column<string>(nullable: false),
                    Servicos = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    BackupId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVIDORES", x => x.ServidorId);
                });

            migrationBuilder.CreateTable(
                name: "BACKUPS",
                columns: table => new
                {
                    BackupId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataHora = table.Column<DateTime>(nullable: false),
                    DataHoraExecucao = table.Column<DateTime>(nullable: false),
                    PeriodoExecucao = table.Column<int>(nullable: false),
                    Assinatura = table.Column<string>(nullable: true),
                    DestinoGravacao = table.Column<int>(nullable: false),
                    ServidorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BACKUPS", x => x.BackupId);
                    table.ForeignKey(
                        name: "FK_BACKUPS_SERVIDORES_ServidorId",
                        column: x => x.ServidorId,
                        principalTable: "SERVIDORES",
                        principalColumn: "ServidorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BACKUPS_ServidorId",
                table: "BACKUPS",
                column: "ServidorId");

            migrationBuilder.CreateIndex(
                name: "IX_ITERACOES_OCORRENCIAS_OcorrenciaId",
                table: "ITERACOES_OCORRENCIAS",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_SERVIDORES_BackupId",
                table: "SERVIDORES",
                column: "BackupId");

            migrationBuilder.AddForeignKey(
                name: "FK_SERVIDORES_BACKUPS_BackupId",
                table: "SERVIDORES",
                column: "BackupId",
                principalTable: "BACKUPS",
                principalColumn: "BackupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BACKUPS_SERVIDORES_ServidorId",
                table: "BACKUPS");

            migrationBuilder.DropTable(
                name: "CONTATOS");

            migrationBuilder.DropTable(
                name: "ITERACOES_OCORRENCIAS");

            migrationBuilder.DropTable(
                name: "ROTINAS");

            migrationBuilder.DropTable(
                name: "OCORRENCIAS");

            migrationBuilder.DropTable(
                name: "SERVIDORES");

            migrationBuilder.DropTable(
                name: "BACKUPS");
        }
    }
}
