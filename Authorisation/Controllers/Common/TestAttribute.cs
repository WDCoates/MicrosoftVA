using System;
using System.Web.Mvc;

namespace Authorisation.Controllers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class TestAttribute : FilterAttribute, IAuthorizationFilter
    {
        private String _name;

        public TestAttribute (params string[] Names)
        {
            _name = "Test";
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Result = null;
            return;
        }
    }
}