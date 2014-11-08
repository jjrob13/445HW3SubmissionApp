using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW3SubmissionPage.Startup))]
namespace HW3SubmissionPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
