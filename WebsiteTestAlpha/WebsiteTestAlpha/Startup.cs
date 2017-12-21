using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteTestAlpha.Startup))]
namespace WebsiteTestAlpha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
