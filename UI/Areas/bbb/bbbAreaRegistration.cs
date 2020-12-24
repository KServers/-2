using System.Web.Mvc;

namespace UI.Areas.bbb
{
    public class bbbAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "bbb";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "bbb_default",
                "bbb/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
