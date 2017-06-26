using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class CountriesController : ApiController
    {
        private static readonly List<cCountry> Country;

        static CountriesController()
        {
            Country = new List<cCountry>();
            cCountry cC = new cCountry();
            cC.Inter = 10;
            cC.name = "England";
            Country.Add(cC);
            cCountry cC2 = new cCountry();
            cC2.Inter = 20;
            cC2.name = "France";
            Country.Add(cC2);
            cCountry cC3 = new cCountry();
            cC3.Inter = 30;
            cC3.name = "Spain";
            Country.Add(cC3);
        }

        public IEnumerable<cCountry> Get()
        {
            return Country;
        }
    }

    public class cCountry
    {
        public int Inter { get; set; }
        public string name { get; set; }
    }
}
