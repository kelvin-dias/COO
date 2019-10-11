using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class ServidorDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Servidor> ObterServidorClassificadosPorNome()
        {
            return context.Servidores.OrderBy(b => b.Nome);
        }

        public Servidor ObterServidorPorId(long id)
        {
            return context.Servidores.Where(p => p.ServidorId == id).First();
        }

        public void GravarServidor(Servidor servidor)
        {
            if (servidor.ServidorId == null)
            {
                context.Servidores.Add(servidor);
            }
            else
            {
                context.Entry(servidor).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public Servidor EliminarServidorPorId(long id)
        {
            Servidor servidor = ObterServidorPorId(id);
            context.Servidores.Remove(servidor);
            context.SaveChanges();
            return servidor;
        }
    }
}
