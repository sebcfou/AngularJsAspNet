using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJsAspNet.Startup))]
namespace AngularJsAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
