using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class OcorrenciaServico
    {
        OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();

        public IQueryable ObterOcorrenciasClassificadasPorDataHora()
        {
            return ocorrenciaDAL.ObterOcorrenciasClassificadasPorDataHora();
        }


        public Ocorrencia ObterOcorrenciaPorId(long? id)
        {
            return ocorrenciaDAL.ObterOcorrenciaPorId(id);
        }

        public void GravarOcorrencia(Ocorrencia ocorrencia)
        {
            ocorrenciaDAL.GravarOcorrencia(ocorrencia);
        }

        public Ocorrencia ObterOcorrenciaPorNumero(long numeroOcorrencia)
        {
            return ocorrenciaDAL.ObterOcorrenciaPorNumero(numeroOcorrencia);
        }
    }
}
