using Modelo.Entidades;
using Servico.Entidades;
using Servico.Tabelas;
using System;
using System.Net;
using System.Web.Mvc;

namespace COO.Controllers
{
    public class OcorrenciaController : Controller
    {
        private OcorrenciaServico ocorrenciaServico = new OcorrenciaServico();
        private IteracaoOcorrenciaServico iteracaoServico = new IteracaoOcorrenciaServico();

        // Métodos do Controlador Ocorrencia
        private ActionResult GravarOcorrencia(Ocorrencia ocorrencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ocorrencia.NumeroOcorrencia = ocorrenciaServico.GerarNumeroOcorrencia();
                    ocorrencia.StatusOcorrencia = 0;
                    ocorrencia.DataHora = DateTime.Now;
                    ocorrenciaServico.GravarOcorrencia(ocorrencia);
                    return RedirectToAction("ConsultarOcorrencia");
                }
                return View(ocorrencia);
            }
            catch
            {
                return View(ocorrencia);
            }
        }

        private ActionResult ObterVisaoOcorrenciaPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocorrencia produto = ocorrenciaServico.ObterOcorrenciaPorId((long)id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Ocorrencia
        public ActionResult ConsultarOcorrencia()
        {
            return View(ocorrenciaServico.ObterOcorrenciasClassificadasPorDataHora());
        }

        // GET: Ocorrencia/Create
        public ActionResult AdicionarOcorrencia()
        {
            return View();
        }

        // POST: Ocorrencia/Create
        [HttpPost]
        public ActionResult AdicionarOcorrencia(Ocorrencia ocorrencia)
        {
            return GravarOcorrencia(ocorrencia);
        }

        //	GET:	Servidor/Details
        public ActionResult DetalharOcorrencia(long? id)
        {
            return ObterVisaoOcorrenciaPorId(id);
        }

        [HttpPost]
        public JsonResult ListarIteracoes(long? Id)
        {
            var iteracoes = iteracaoServico.ObterIteracoes(Id);
            return Json(iteracoes, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public ActionResult AdicionarIteracoes(IteracaoOcorrencia iteracao)
        //{

        //    return iteracaoServico.GravarIteracao(iteracao);

        //}

    }
}