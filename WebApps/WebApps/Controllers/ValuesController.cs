using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApps.Controllers
{
    public class TestValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok (new [] {"Tall", "Leather", "Boots" });
        }
    }
}
