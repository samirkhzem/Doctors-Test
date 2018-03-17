using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doctors.Startup))]
namespace Doctors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
