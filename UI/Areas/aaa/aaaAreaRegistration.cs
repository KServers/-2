using System.Web.Mvc;

namespace UI.Areas.aaa
{
    public class aaaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "aaa";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "aaa_default",
                "aaa/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
