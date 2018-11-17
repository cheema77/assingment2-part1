using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_music_app.Startup))]
namespace mvc_music_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
