using Persistencia.DAL.Entidades;

namespace Servico.Tabelas
{
    public class DashboardServico
    {
        OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();

        public int ObterQuantidadeOcorrenciaStatusAberto()
        {
            return ocorrenciaDAL.ObterQuantidadeOcorrenciaStatusAberto();
        }
    }
}
