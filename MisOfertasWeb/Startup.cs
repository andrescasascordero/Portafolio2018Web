using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MisOfertasWeb.Startup))]
namespace MisOfertasWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
