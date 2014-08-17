using System.Web.Mvc;

namespace TJG_WebForms_MVC_Mash.MvcHelpers
{
    public class DummyController : Controller
    {
        public ActionResult PartialRender()
        {
            return PartialView();
        } 
    }
}