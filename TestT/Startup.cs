using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestT.Startup))]
namespace TestT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
