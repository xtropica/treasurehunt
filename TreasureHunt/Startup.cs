using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreasureHunt.Startup))]
namespace TreasureHunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
