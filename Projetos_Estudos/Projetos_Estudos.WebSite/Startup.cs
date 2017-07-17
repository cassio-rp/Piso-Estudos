using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projetos_Estudos.WebSite.Startup))]
namespace Projetos_Estudos.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
