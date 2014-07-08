using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodedPizza.Web.Startup))]
namespace CodedPizza.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
