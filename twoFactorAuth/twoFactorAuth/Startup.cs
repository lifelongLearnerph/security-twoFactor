using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(twoFactorAuth.Startup))]
namespace twoFactorAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
