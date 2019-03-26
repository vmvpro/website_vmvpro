using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vmvpro_mvc.Startup))]
namespace vmvpro_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
