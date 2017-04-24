using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnGiuaKi.Startup))]
namespace DoAnGiuaKi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
