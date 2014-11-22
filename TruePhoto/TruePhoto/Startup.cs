using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruePhoto.Startup))]
namespace TruePhoto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
