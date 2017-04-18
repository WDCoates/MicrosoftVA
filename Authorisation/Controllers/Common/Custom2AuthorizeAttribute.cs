using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Authorisation.Controllers
{

    //TODO: The redirection does not quite work!
    public class Custom2AuthorizeAttribute : AuthorizeAttribute
    {
        //Entities context = new Entities(); // my entity when I get one...
        private readonly string[] allowedroles;
        public Custom2AuthorizeAttribute(params string[] Roles)
        {
            this.allowedroles = Roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            foreach (var role in allowedroles)
            {
                //var user = context.AspNetUsers.Where(m => m.Id == httpContext.User.Identity && m.Role == role && m.IsActive == true); // checking active users with allowed roles.  
                //var user = context.AspNetUsers.Where(m => m.UserName == "DaveC" ); // checking active users with allowed roles.  
                //if (user.Count() > 0)
                //{
                //    authorize = true; /* return true if Entity has current user(active) with specific role */
                //}
            }
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }

}