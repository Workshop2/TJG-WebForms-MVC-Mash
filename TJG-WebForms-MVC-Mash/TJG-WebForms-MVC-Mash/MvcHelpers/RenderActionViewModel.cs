namespace TJG_WebForms_MVC_Mash.MvcHelpers
{
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; } 
    }
}