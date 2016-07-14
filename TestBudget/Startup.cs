using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestBudget.Startup))]
namespace TestBudget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
