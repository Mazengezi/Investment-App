using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Investment.UI.Startup))]
namespace Investment.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
