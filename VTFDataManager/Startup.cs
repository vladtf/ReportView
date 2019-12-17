using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(VTFDataManager.Startup))]

namespace VTFDataManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}