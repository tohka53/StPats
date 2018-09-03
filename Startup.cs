using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StPats.Startup))]
namespace StPats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
