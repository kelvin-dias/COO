using Modelo.Entidades.Enumeradores;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("ROTINAS")]
    public class Rotina
    {
        public int RotinaId { get; set; }
        public string Nome { get; set; }
        public int OrdemDeServico { get; set; }
        public BancoDeExecucao Execucao { get; set; }
        public string ResponsavelDaRotina { get; set; }
        public string Assinatura { get; set; }
    }
}
