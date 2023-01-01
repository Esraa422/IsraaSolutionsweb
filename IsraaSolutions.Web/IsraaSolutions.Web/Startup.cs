using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsraaApp.WebMVC.Startup))]
namespace IsraaApp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }        
    }
}