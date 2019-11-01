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
        public DbSet<IteracaoOcorrencia> IteracoesOcorrencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvi\source\repos\COO\COO\App_Data\COO.mdf;Integrated Security=True;Connect Timeout=90");
        }
    }

}






