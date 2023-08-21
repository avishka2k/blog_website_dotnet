using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blogsite_asp.Startup))]
namespace blogsite_asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
