using System.Web.Mvc;
using External.Library.Areas.Test.Models;

namespace External.Library.Areas.Test.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View(new AdminModel { Test = "lalalala" });
        }
    }
}