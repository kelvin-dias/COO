using Modelo.Entidades;
using Servico.Entidades;
using System;
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
                    servidorServico.GravarServidor(servidor);
                    return RedirectToAction("ConsultarServidor");
            }
            catch
            {
                return View(servidor);
            }
        }

        // GET: Servidor/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConsultarServidor()
        {
            return View(servidorServico.ObterCategoriasClassificadasPorNome());
        }

        // GET: Servidor/Create
        //public ActionResult AdicionarServidor()
        //{
        //    return View();
        //}

        // POST: Servidor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarServidor(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //[HttpPost]
        //public string Adicionar(Servidor servidor)
        //{
        //    if (servidor != null)
        //    {
        //        //TODO: salvar dados no banco de dados
        //        GravarServidor(servidor);
        //        return "Obrigado. O dados foram Salvos.";
        //    }
        //    else
        //    {
        //        return "Complete a informação do formulário.";
        //    }
        //}


        //	GET: Servidor/Edit
        [HttpGet]
        public ActionResult EditarServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        // POST: Servidor/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarServidor(Servidor servidor)
        {
            return GravarServidor(servidor);
        }

        //	GET:	Servidor/Details
        [HttpGet]
        public ActionResult DetalharServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	GET:	Servidor/Delete
        [HttpGet]
        public ActionResult DeletarServidor(long? id)
        {
            return ObterVisaoServidorPorId(id);
        }

        //	POST:	Servidor/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarServidor(long id)
        {
            try
            {
                Servidor servidor = servidorServico.EliminarServidorPorId(id);
                TempData["Message"] = "Servidor " + servidor.Nome
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