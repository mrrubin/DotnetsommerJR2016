using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Githubtest.Startup))]
namespace Githubtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
