using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internet_Voting_System.Startup))]
namespace Internet_Voting_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
