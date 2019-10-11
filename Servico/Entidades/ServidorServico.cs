using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class ServidorServico
    {
        private ServidorDAL servidorDAL = new ServidorDAL();

        public IQueryable ObterCategoriasClassificadasPorNome()
        {
            return servidorDAL.ObterServidorClassificadosPorNome();
        }

        public Servidor ObterServidorPorId(long id)
        {
            return servidorDAL.ObterServidorPorId(id);
        }

        public void GravarServidor(Servidor servidor)
        {
            servidorDAL.GravarServidor(servidor);
        }

        public Servidor EliminarServidorPorId(long id)
        {
            return servidorDAL.EliminarServidorPorId(id);
        }
    }
}
