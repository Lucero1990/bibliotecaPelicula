using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWebMVC5.Startup))]
namespace AppWebMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
