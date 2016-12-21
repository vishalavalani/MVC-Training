using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstDbApp.Startup))]
namespace FirstDbApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
