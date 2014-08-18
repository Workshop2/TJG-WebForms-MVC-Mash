using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TJG_WebForms_MVC_Mash.Areas.Test.Controllers;

namespace TJG_WebForms_MVC_Mash
{
    public class WebFormController : Controller { }

    public static class WebFormMVCUtil
    {
        public static void RenderPartial(string partialName, object model)
        {
            // get a wrapper for the legacy WebForm context
            var httpContextWrapper = new HttpContextWrapper(HttpContext.Current);

            // create a mock route that points to the empty controller
            var routeData = new RouteData();
            routeData.DataTokens.Add("area", "Test");
            routeData.Values.Add("controller", "AdminController");

            var controller = new AdminController();

            // create a controller context for the route and http context
            var requestContext = new RequestContext(httpContextWrapper, routeData);
            var controllerContext = new ControllerContext(requestContext, controller);

            // find the partial view using the viewengine
            ViewEngineResult findView = ViewEngines.Engines.FindView(controllerContext, "index", "");
            ViewEngineResult findPartialView = ViewEngines.Engines.FindPartialView(controllerContext, partialName);
            var view = findPartialView.View as RazorView;

            // create a view context and assign the model
            var viewContext = new ViewContext(controllerContext, view, new ViewDataDictionary { Model = model }, new TempDataDictionary(), httpContextWrapper.Response.Output);

            // render the partial view
            view.Render(viewContext, httpContextWrapper.Response.Output);
        }
    }
}