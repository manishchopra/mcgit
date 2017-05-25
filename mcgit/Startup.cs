using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mcgit.Startup))]
namespace mcgit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
