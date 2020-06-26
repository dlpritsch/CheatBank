using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheatBank.Startup))]
namespace CheatBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
