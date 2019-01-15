using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Employee.Startup))]
namespace Project_Employee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
