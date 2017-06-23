using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_105_Final.Startup))]
namespace _105_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
