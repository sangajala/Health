using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sree_Health.Startup))]
namespace Sree_Health
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
