using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHV263.Startup))]
namespace WebHV263
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
