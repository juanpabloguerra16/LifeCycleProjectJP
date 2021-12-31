using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLifeCyple.Startup))]
namespace MVCLifeCyple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
