using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataDrunk.Startup))]
namespace DataDrunk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
