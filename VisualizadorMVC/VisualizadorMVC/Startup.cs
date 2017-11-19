using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualizadorMVC.Startup))]
namespace VisualizadorMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
