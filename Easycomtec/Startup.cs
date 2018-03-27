using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Easycomtec.Startup))]
namespace Easycomtec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
