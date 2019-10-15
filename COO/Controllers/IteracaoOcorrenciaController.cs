using Modelo.Entidades;
using Servico.Tabelas;
using System;
using System.Web.Mvc;

namespace COO.Controllers
{
    public class IteracaoOcorrenciaController : Controller
    {
        private IteracaoOcorrenciaServico iteracaoServico = new IteracaoOcorrenciaServico();

        // GET: Iteracao
        public ActionResult ConsultarIteracao(long? Id)
        {
            return View(iteracaoServico.ObterIteracoes(Id));
        }

        // GET: Servidor/Create
        public ActionResult AdicionarIteracao()
        {
            return View();
        }

        // POST: Gravar Iteracao
        [HttpPost]
        public ActionResult AdicionarIteracao(long? Id, IteracaoOcorrencia iteracao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    iteracao.OcorrenciaId = Id;
                    iteracao.DataHoraIteracao = DateTime.Now;

                    iteracaoServico.GravarIteracao(iteracao);
                    return RedirectToAction("ConsultarOcorrencia", "Ocorrencia", new { Id = iteracao.OcorrenciaId });
                }
                return View(iteracao);
            }
            catch
            {
                return View(iteracao);
            }
        }
    }
}