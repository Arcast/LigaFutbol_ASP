using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LigaFutbol_ASP.Startup))]
namespace LigaFutbol_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
