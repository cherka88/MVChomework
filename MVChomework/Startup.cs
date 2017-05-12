using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVChomework.Startup))]
namespace MVChomework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
