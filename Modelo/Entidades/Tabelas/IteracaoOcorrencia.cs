using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades.Tabelas
{
    [Table("ITERACOES_OCORRENCIA")]
    public class IteracaoOcorrencia
    {
        public long? IteracaoOcorrenciaId { get; set; }
        public string TextoIteracao { get; set; }
        public DateTime DataHoraIteracao { get; set; }
        public string Assinatura { get; set; }
        public long? OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
