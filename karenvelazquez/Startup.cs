using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(karenvelazquez.Startup))]
namespace karenvelazquez
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
