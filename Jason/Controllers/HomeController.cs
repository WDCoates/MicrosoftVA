using System.IO;
using System.Web;
using System.Web.Mvc;
using Jason.Areas;

namespace Jason.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

    }

}
