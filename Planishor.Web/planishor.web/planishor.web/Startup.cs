using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(planishor.web.Startup))]
namespace planishor.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
