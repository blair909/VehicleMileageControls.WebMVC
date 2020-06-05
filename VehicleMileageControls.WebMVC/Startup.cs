using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleMileageControls.WebMVC.Startup))]
namespace VehicleMileageControls.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
