using Modelo.Entidades;
using Persistencia.DAL.Tabelas;
using System.Linq;

namespace Servico.Tabelas
{
    public class IteracaoOcorrenciaServico
    {
        IteracaoOcorrenciaDAL ocorrenciaDAL = new IteracaoOcorrenciaDAL();

        public IQueryable ObterIteracoes(long? Id)
        {
            return ocorrenciaDAL.ObterIteracoes(Id);
        }

        public void GravarIteracao(IteracaoOcorrencia iteracao)
        {
            ocorrenciaDAL.GravarIteracao(iteracao);
        }
    }
}
