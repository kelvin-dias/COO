using Servico.Tabelas;
using System;
using System.Web.Mvc;

namespace COO.Controllers
{
    public class DashboardController : Controller
    {
        private DashboardServico dashboardServico = new DashboardServico();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ObterDados()
        {
            ViewBag.QtdOcorrencias = dashboardServico.ObterQuantidadeOcorrenciaStatusAberto();

            return Json(ViewBag.QtdOcorrencias, JsonRequestBehavior.AllowGet);
        }

    }
}