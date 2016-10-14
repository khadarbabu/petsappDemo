using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AimiaOnlinePetsShopping.Startup))]
namespace AimiaOnlinePetsShopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
