using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindWebsite.Startup))]
namespace NorthwindWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
