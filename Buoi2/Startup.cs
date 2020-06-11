using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buoi2.Startup))]
namespace Buoi2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
