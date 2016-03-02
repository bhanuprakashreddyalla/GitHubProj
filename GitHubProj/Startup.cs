using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubProj.Startup))]
namespace GitHubProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
