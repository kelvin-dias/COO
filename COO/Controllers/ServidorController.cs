using Modelo.Entidades;
using Servico.Entidades;
using System.Net;
using System.Web.Mvc;

namespace COO.Controllers
{
    public class ServidorController : Controller
    {
        private ServidorServico servidorServico = new ServidorServico();

        //Métodos do Controlador Servidor
        private ActionResult ObterVisaoServidorPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servidor produto = servidorServico.ObterServidorPorId((long)id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        private ActionResult GravarServidor(Servidor servidor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servidorServico.GravarServidor(servidor);
                    return RedirectToAction("ConsultarServidor");
                }
                return View(servidor);
            }
            catch
            {
                return View(servidor);
            }
        }

        // GET: Servidor/Index
        public ActionResult ConsultarServidor()
        {
            return View(servidorServico.ObterCategoriasClassificadasPorNome());
        }

        // GET: Servidor/Create
        public ActionResult AdicionarServidor()
        {
            return View();
        }

        // POST: Servidor/Create
        [HttpPost]
        public ActionResult AdicionarServidor(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //	GET: Servidor/Edit
        public ActionResult EditarServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        // POST: Servidor/Edit
        [HttpPost]
        public ActionResult EditarServidor(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //	GET:	Servidor/Details
        public ActionResult DetalharServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	GET:	Servidor/Delete
        public ActionResult DeletarServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	POST:	Servidor/Delete
        [HttpPost]
        public ActionResult DeletarServidor(long id)
        {
            try
            {
                Servidor servidor = servidorServico.EliminarServidorPorId(id);
                TempData["Message"] = "Servidor " + servidor.Nome.ToUpper()
                + " foi removido";
                return RedirectToAction("ConsultarServidor");
            }
            catch
            {
                return View();
            }
        }
    }
}