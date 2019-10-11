using Modelo.Entidades.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("BACKUPS")]
    public class Backup
    {
        public long? BackupId { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime DataHoraExecucao { get; set; }
        public Periodo PeriodoExecucao { get; set; }
        public string Assinatura { get; set; }
        public BancoDeExecucao DestinoGravacao { get; set; }
    }
}
