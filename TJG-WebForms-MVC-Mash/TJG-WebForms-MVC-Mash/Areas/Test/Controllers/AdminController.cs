using System.Web.Mvc;
using TJG_WebForms_MVC_Mash.Areas.Test.Models;

namespace TJG_WebForms_MVC_Mash.Areas.Test.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View(new AdminModel { Test = "lalalala" });
        }
    }
}