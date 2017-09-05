using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteerTracking.Startup))]
namespace VolunteerTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
