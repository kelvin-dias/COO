using Modelo.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("OCORRENCIAS")]
    public class Ocorrencia
    {
        [DisplayName("ID")]
        public long? OcorrenciaId { get; set; }

        [DisplayName("Número Ocorrência")]
        public long? NumeroOcorrencia { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Informe o Título da Ocorrência")]
        public string Titulo { get; set; }

        [DisplayName("Data e Hora")]
        public DateTime DataHora { get; set; }

        [DisplayName("Status")]
        public Status StatusOcorrencia { get; set; }

        [DisplayName("Criticidade")]
        [Required(ErrorMessage = "Informe a Criticidade da Ocorrência")]
        public Criticidade CriticidadeOcorrencia { get; set; }

        [DisplayName("Solução")]
        public string Solucao { get; set; }

        public ICollection<OcorrenciaIteracao> Iteracoes { get; set; }
    }
}
