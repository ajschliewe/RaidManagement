using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaidManagementWeb.Startup))]
namespace RaidManagementWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
