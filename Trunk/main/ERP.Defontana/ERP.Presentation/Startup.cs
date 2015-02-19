using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERP.Presentation.Startup))]
namespace ERP.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
