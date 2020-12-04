using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurfLocalShop.Startup))]
namespace SurfLocalShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
