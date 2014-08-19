using System.Web.Mvc;

namespace AnotherAttempt.Areas.TestingBounds
{
    public class TestingBoundsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TestingBounds";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            var route = context.MapRoute(
                name: "TestingBounds_default",
                url: "TestingBounds/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AnotherAttempt.Areas.TestingBounds.Controllers", "AnotherAttempt.Areas.TestingBounds.Views", "AnotherAttempt.Areas.TestingBounds.Views.Shared" }
            );
            //route.DataTokens["UseNamespaceFallback"] = false;
        }
    }
}