using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi2ProjectTemplateCompare.Startup))]
namespace WebApi2ProjectTemplateCompare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
