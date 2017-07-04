using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KavaPoint.Startup))]
namespace KavaPoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
