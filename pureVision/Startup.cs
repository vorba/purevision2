using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pureVision.Startup))]
namespace pureVision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
