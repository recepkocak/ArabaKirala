using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(arabakirala.Startup))]
namespace arabakirala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
