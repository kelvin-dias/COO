using Modelo.Entidades;
using Servico.Entidades;
using System;
using System.Net;
using System.Web.Mvc;

namespace COO.Controllers
{
    public class OcorrenciaController : Controller
    {
        private OcorrenciaServico ocorrenciaServico = new OcorrenciaServico();

        // Métodos do Controlador Ocorrencia
        private ActionResult GravarOcorrencia(Ocorrencia ocorrencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Geração do número aleatório da Ocorrência
                    Random randNum = new Random();
                    bool statusValidacao = false;

                    do
                    {
                        long numero = randNum.Next(100000, 999999);
                        Ocorrencia produto = ocorrenciaServico.ObterOcorrenciaPorNumero((long)numero);


                        if (produto == null)
                        {
                            statusValidacao = true;
                        }

                    } while (statusValidacao == false);


                    ocorrencia.StatusOcorrencia = 0;
                    ocorrencia.DataHora = DateTime.Now;
                    ocorrenciaServico.GravarServidor(ocorrencia);
                    return RedirectToAction("Index");
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
    }
}