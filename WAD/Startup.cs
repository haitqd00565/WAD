using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAD.Startup))]
namespace WAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
