using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyExampleApps.Startup))]
namespace MyExampleApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
