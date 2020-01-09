using System.Web.Mvc;

namespace COO.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}