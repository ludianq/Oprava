using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oprava.Backend.Startup))]
namespace Oprava.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
