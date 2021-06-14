using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CineStore.Startup))]
namespace CineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
