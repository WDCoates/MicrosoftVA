using System.Web;
using System.Web.Http;

using Jason.Areas;

namespace Jason.Controllers
{
    public class apiController : ApiController
    {
        public HttpResponse GetOptions()
        {
            var JSONstring = Utility.GetJFile();

            return null;
        }
    }
}
