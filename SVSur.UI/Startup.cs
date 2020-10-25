using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVSur.UI.Startup))]
namespace SVSur.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
