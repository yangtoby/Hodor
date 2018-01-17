using System.Web.Mvc;

namespace NFine.WebT.Areas.TaskManage
{
    public class TaskManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TaskManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TaskManage_default",
                "TaskManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
