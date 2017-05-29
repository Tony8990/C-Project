using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaWeb.Startup))]
namespace CinemaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
