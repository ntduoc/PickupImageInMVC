using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PickupImage.Startup))]
namespace PickupImage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
