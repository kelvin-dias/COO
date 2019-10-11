using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace Persistencia.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Backup> Backups { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Rotina> Rotinas { get; set; }
        public DbSet<Servidor> Servidores { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<OcorrenciaIteracao> OcorrenciaIteracoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fadami\source\repos\ControleOperacional\ControleOperacional\App_Data\CONTROLE_OPERACIONAL.mdf;Integrated Security=True");
        }
    }

}






