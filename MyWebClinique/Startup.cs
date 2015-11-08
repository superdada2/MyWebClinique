using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebClinique.Startup))]
namespace MyWebClinique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
