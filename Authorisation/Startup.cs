using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authorisation.Startup))]
namespace Authorisation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
