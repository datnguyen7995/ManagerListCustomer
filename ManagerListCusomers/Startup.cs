using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManagerListCusomers.Startup))]
namespace ManagerListCusomers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
