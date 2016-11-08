using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazingClicker.Startup))]
namespace AmazingClicker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
