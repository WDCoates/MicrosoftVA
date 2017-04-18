using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorisation.Controllers
{

    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {

        //public override void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    if (filterContext == null)
        //    {
        //        throw new ArgumentNullException("filterContext");
        //    }

        //    if (OutputCacheAttribute.IsChildActionCacheActive(filterContext))
        //    {
        //        throw new InvalidOperationException(MvcResources.AuthorizeAttribute_CannotUseWithinChildActionCache);
        //    }

        //    bool skipAuthorization = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), inherit: true)
        //                             || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), inherit: true);

        //    if (skipAuthorization)
        //    {
        //        return;
        //    }

        //    if (AuthorizeCore(filterContext.HttpContext))
        //    {
        //        HttpCachePolicyBase cachePolicy = filterContext.HttpContext.Response.Cache;
        //        cachePolicy.SetProxyMaxAge(new TimeSpan(0));

        //        var actionDescriptor = filterContext.ActionDescriptor;
        //        var currentAction = actionDescriptor.ActionName;
        //        var currentController = actionDescriptor.ControllerDescriptor.ControllerName;

        //        var hasHttpPostAttribute = actionDescriptor.GetCustomAttributes(typeof(HttpPostAttribute), true).Any();
        //        var hasHttpGetAttribute = actionDescriptor.GetCustomAttributes(typeof(HttpGetAttribute), true).Any();
        //        // fill the data parameter which is null by default
        //        cachePolicy.AddValidationCallback(CacheValidateHandler, new { actionDescriptor : actionDescriptor, currentAction: currentAction, currentController: currentController, hasHttpPostAttribute : hasHttpPostAttribute, hasHttpGetAttribute: hasHttpGetAttribute });
        //    }
        //    else
        //    {
        //        HandleUnauthorizedRequest(filterContext);
        //    }
        //}

        //private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
        //{
        //    if (httpContext == null)
        //    {
        //        throw new ArgumentNullException("httpContext");
        //    }
        //    // the data will contain AuthorizationContext attributes
        //    bool isAuthorized = myAuthorizationLogic(httpContext, data);
        //    return (isAuthorized) ? HttpValidationStatus.Valid : httpValidationStatus.IgnoreThisRequest;

        //}
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Result = CreateResult(filterContext);
        }

        protected ActionResult CreateResult(AuthorizationContext filterContext)
        {
            var controllerContext = new ControllerContext(filterContext.RequestContext, filterContext.Controller);
            var controller = (string)filterContext.RouteData.Values["controller"];
            var action = (string)filterContext.RouteData.Values["action"];
            // any custom model here
            //var model = new UnauthorizedModel();

            // custom logic to determine proper view here - i'm just hardcoding it
            var viewName = "~/Views/Shared/Unauthorized.cshtml";

            return new ViewResult
            {
                ViewName = viewName,
                //ViewData = new ViewDataDictionary<UnauthorizedModel>(model)
            };
        }
    }
}