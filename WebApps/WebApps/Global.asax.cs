using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApps
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            CheckRoutes(RouteTable.Routes);
        }

        public static void CheckRoutes(RouteCollection rCol)
        {
            foreach (var r in rCol)
            {
                Console.WriteLine("{0}", r.RouteExistingFiles);
            }
            
        }
    }
}
