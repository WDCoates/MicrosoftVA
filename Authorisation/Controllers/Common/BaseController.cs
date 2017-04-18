using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorisation.Controllers
{
    public abstract partial class BaseController : Controller
    {
        public SchoolContext db = new SchoolContext();
        //public MenuNav Navigation = new MenuNav();

        public string UrlLanguage { get; set; }
        public string UrlCountry { get; set; }
        public string UrlSchool { get; set; }
        public string UrlController { get; set; }
        public string UrlAction { get; set; }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            UrlCountry = filterContext.Controller.ControllerContext.RequestContext.RouteData.Values["country"].ToString();
            UrlSchool = filterContext.Controller.ControllerContext.RequestContext.RouteData.Values["school"].ToString();
            UrlController = filterContext.Controller.ControllerContext.RequestContext.RouteData.Values["controller"].ToString();
            UrlAction = filterContext.Controller.ControllerContext.RequestContext.RouteData.Values["action"].ToString();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Navigation.MenuItems = db.MenuItems.SqlQuery("dbo.ReturnMenuItemsByUser").ToList();
        }
    }
}