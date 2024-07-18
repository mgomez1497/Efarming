using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Services.Description;


[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {

       

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureAuth(app);
            app.UseWebApi(config);

        }
    }
}
