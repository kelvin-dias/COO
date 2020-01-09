using System.Web.Mvc;

namespace COO.Controllers
{
    public class RotinaController : Controller
    {
        // GET: Rotina
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}