using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backups_SERVIDORES_ServidorId",
                table: "Backups");

            migrationBuilder.DropForeignKey(
                name: "FK_SERVIDORES_Backups_BackupId",
                table: "SERVIDORES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backups",
                table: "Backups");

            migrationBuilder.RenameTable(
                name: "Backups",
                newName: "BACKUPS");

            migrationBuilder.RenameIndex(
                name: "IX_Backups_ServidorId",
                table: "BACKUPS",
                newName: "IX_BACKUPS_ServidorId");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "SERVIDORES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Servicos",
                table: "SERVIDORES",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BACKUPS",
                table: "BACKUPS",
                column: "BackupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BACKUPS_SERVIDORES_ServidorId",
                table: "BACKUPS",
                column: "ServidorId",
                principalTable: "SERVIDORES",
                principalColumn: "ServidorId",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.DropForeignKey(
                name: "FK_SERVIDORES_BACKUPS_BackupId",
                table: "SERVIDORES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BACKUPS",
                table: "BACKUPS");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "SERVIDORES");

            migrationBuilder.DropColumn(
                name: "Servicos",
                table: "SERVIDORES");

            migrationBuilder.RenameTable(
                name: "BACKUPS",
                newName: "Backups");

            migrationBuilder.RenameIndex(
                name: "IX_BACKUPS_ServidorId",
                table: "Backups",
                newName: "IX_Backups_ServidorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backups",
                table: "Backups",
                column: "BackupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backups_SERVIDORES_ServidorId",
                table: "Backups",
                column: "ServidorId",
                principalTable: "SERVIDORES",
                principalColumn: "ServidorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SERVIDORES_Backups_BackupId",
                table: "SERVIDORES",
                column: "BackupId",
                principalTable: "Backups",
                principalColumn: "BackupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
