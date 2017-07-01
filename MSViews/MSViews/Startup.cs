using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSViews.Startup))]
namespace MSViews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
