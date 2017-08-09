using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WestSprings_Web.Startup))]
namespace WestSprings_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
