using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTwitter.App.Startup))]
namespace MyTwitter.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
