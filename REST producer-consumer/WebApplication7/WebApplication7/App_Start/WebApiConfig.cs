using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;

namespace WebApplication7
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{Action}/{id}/{id1}",
            defaults: new { controller = "Valid", Action = "Check ", id = RouteParameter.Optional, id1 = RouteParameter.Optional });

                

                      config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());


            

           
        }
    }
}
