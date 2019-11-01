using Modelo.Entidades;
using Persistencia.Context;
using System;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class OcorrenciaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Ocorrencia> ObterOcorrenciasClassificadasPorDataHora()
        {
            return context.Ocorrencias.OrderBy(b => b.DataHora);
        }

        public Ocorrencia ObterOcorrenciaPorId(long? id)
        {
            return context.Ocorrencias.Where(p => p.OcorrenciaId == id).First();
        }

        public void GravarOcorrencia(Ocorrencia ocorrencia)
        {
            context.Ocorrencias.Add(ocorrencia);
            context.SaveChanges();
        }

        public Ocorrencia ObterOcorrenciaPorNumero(long numeroOcorrencia)
        {
            return context.Ocorrencias.FirstOrDefault(x => x.NumeroOcorrencia == numeroOcorrencia);
        }

        public int ObterQuantidadeOcorrenciaStatusAberto()
        {
            var query = context.Ocorrencias.Where(p => p.StatusOcorrencia == Modelo.Entidades.Enumeradores.Status.Aberto);

            int contagem = query.Count();

            return contagem;
        }
    }
}
