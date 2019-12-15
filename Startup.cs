using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRentals.Startup))]
namespace VideoRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
