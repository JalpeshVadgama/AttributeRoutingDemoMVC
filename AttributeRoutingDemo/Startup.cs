using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttributeRoutingDemo.Startup))]
namespace AttributeRoutingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
