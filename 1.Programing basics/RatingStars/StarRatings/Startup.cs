using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarRatings.Startup))]
namespace StarRatings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
