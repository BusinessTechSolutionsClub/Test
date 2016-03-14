using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolStudentEnrollmentApp.Startup))]
namespace SchoolStudentEnrollmentApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
