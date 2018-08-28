using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Events.Web.Startup))]
namespace Events.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
