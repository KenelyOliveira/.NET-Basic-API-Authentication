using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(kenely.AuthenticationToken.API.Startup))]

namespace kenely.AuthenticationToken.API
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      HttpConfiguration config = new HttpConfiguration();
      WebApiConfig.Register(config);
      app.UseWebApi(config);
    }
  }
}
