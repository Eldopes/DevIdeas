using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIdeas.Startup))]
namespace DevIdeas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
