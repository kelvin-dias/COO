using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("ITERACOES_OCORRENCIAS")]
    public class OcorrenciaIteracao
    {
        public long? OcorrenciaIteracaoId { get; set; }
        public string TextoIteracao { get; set; }
        public DateTime DataHoraIteracao { get; set; }
        public string Assinatura { get; set; }
        public long? OcorrenciaId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
    }
}
