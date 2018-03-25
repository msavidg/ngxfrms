using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json.Serialization;

namespace ngxFrmsWebApi
{
  public class WebApiApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {

      // https://stackoverflow.com/questions/28552567/web-api-2-how-to-return-json-with-camelcased-property-names-on-objects-and-the

      GlobalConfiguration.Configure(WebApiConfig.Register);

      HttpConfiguration config = GlobalConfiguration.Configuration;
      config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
      config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

    }
  }
}
