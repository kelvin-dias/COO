using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System;
using System.Linq;

namespace Persistencia.DAL.Tabelas
{
    public class IteracaoOcorrenciaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<IteracaoOcorrencia> ObterIteracoes(long? Id)
        {
            return context.IteracoesOcorrencias.Where(p => p.OcorrenciaId == Id)
                .OrderBy(p => p.DataHoraIteracao);
        }

        public void GravarIteracao(IteracaoOcorrencia iteracao)
        {
            {
                if (iteracao.IteracaoOcorrenciaId == null)
                {
                    context.IteracoesOcorrencias.Add(iteracao);
                }
                else
                {
                    context.Entry(iteracao).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }
    }
}
