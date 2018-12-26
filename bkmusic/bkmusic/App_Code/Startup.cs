using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bkmusic.Startup))]
namespace bkmusic
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
