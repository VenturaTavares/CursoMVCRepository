using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VP.CursoMVC.UI.Mvc.Startup))]
namespace VP.CursoMVC.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
