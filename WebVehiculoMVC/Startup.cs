using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebVehiculoMVC.Startup))]
namespace WebVehiculoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
