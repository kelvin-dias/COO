using Modelo.Entidades.Enumeradores;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("SERVIDORES")]
    public class Servidor
    {
        [DisplayName("Código")]
        public long? ServidorId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe o nome do Servidor")]
        public string Nome { get; set; }

        [DisplayName("Ambiente")]
        [Required(ErrorMessage = "Escolha o Ambiente do Servidor")]
        public Ambiente AmbienteServidor { get; set; }

        [DisplayName("IP")]
        [Required(ErrorMessage = "Informe o Ip do Servidor")]
        public string ServidorIp { get; set; }
        public long? BackupId { get; set; }
        public Backup Backup { get; set; }
        public ICollection<Backup> BackupServidor { get; set; }
    }
}
