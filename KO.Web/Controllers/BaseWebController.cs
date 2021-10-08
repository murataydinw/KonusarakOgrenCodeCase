using KO.Web.Helper;
using KO.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KO.Web.Controllers
{
    public class BaseWebController : Controller
    {

        internal int UserSessionId
        {
            get => ViewBag.UserSessionId;
            set => ViewBag.UserSessionId = value;
        }

        internal UserSession UserSession
        {
            get => ViewBag.UserSession;
            set => ViewBag.UserSession = value;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var actionDescriptor = filterContext.ActionDescriptor as dynamic;
            var controllerName = actionDescriptor.ControllerName;
            var actionName = actionDescriptor.ActionName;
            var method = filterContext.HttpContext.Request.Method;




            var userSession = HttpContext.Session.GetSession<UserSession>("UserSession");

            if (userSession != null)
            {

                if (filterContext.Controller is Controller controller)
                {
                    //GET: var sessionUserId = ViewData["CustomerUserId"].GetObjectValue<int>();
                    controller.ViewData["UserSessionId"] = userSession.Id;
                    controller.ViewData["UserSession"] = userSession;
                }


                #region 
                ViewBag.UserSession = userSession;
                UserSessionId = userSession.Id;
                UserSession = userSession;
                HttpContext.Session.SetSession("CustomerSession", userSession);
                #endregion
            }
            else
            {
                UserSessionId = 0;
            }

            if (controllerName == "Home" && UserSessionId == 0)
            {
                filterContext.Result = new RedirectResult("/login");
                return;
            }
        }
    }
}
