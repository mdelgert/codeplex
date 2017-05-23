using System;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Base.Core.Utils;

namespace Base.Core.HttpHost
{
    public class Server
    {

        public void StartServices()
        {
            Console.WriteLine("Begin starting web services:");
            this.StartHost();
        }

        private void StartHost()
        {

            var config = new HttpSelfHostConfiguration(HostAddress());

            config.Routes.MapHttpRoute(
                name: "CoreApi",
                routeTemplate: "CoreApi/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });


            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Run following url in Chrome browser to test " + HostAddress() + "/CoreApi/Task");
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }

            Console.WriteLine("End starting web services:");

        }

        public string HostAddress()
        {

            bool useHostBaseAddress = AppSettingsCfg.GetUseHostBaseAddressKey();
            bool useHostBasePort = AppSettingsCfg.GetUseHostBasePortKey();
            string hostAddress = AppSettingsCfg.GetHostBaseAddressKey();
            string hostBasePort = AppSettingsCfg.GetHostBasePortKey();
            string host = null;

            if (!useHostBaseAddress)
            {
                host = "http://" + Common.GetLocalIP();
            }
            else
            {
                host = hostAddress;
            }

            if (!useHostBasePort)
            {
                host = host + ":80";
            }
            else
            {
                host = host + ":" + hostBasePort;
            }

            return host;

        }

    }

}











//config.Routes.MapHttpRoute(
//        "DefaultApi", "api/{controller}/{id}",
//        new { id = RouteParameter.Optional });

//config.Routes.MapHttpRoute(
//    name: "styles",
//    routeTemplate: "styles/{id}",
//    defaults: new { controller = "File", path = "styles/" });

//config.Routes.MapHttpRoute(
//    name: "stylesDefault",
//    routeTemplate: "styles/Default/{id}",
//    defaults: new { controller = "File", path = "styles/Default/" });

//config.Routes.MapHttpRoute(
//    name: "stylestextures",
//    routeTemplate: "textures/Default/{id}",
//    defaults: new { controller = "File", path = "styles/textures/" });

//config.Routes.MapHttpRoute(
//    name: "js",
//    routeTemplate: "js/{id}",
//    defaults: new { controller = "File", path = "js/" });

//config.Routes.MapHttpRoute(
//    name: "Default",
//    routeTemplate: "{controller}/{id}",
//    defaults: new { controller = "File", id = "Index.html" });

//config.Routes.MapHttpRoute(
//    "CrossDomainServer", "crossdomain.xml",
//    new { controller = "CrossDomain", policyId = 0 });

//config.Routes.MapHttpRoute(
//    "CrossDomainClient", "clientaccesspolicy.xml",
//    new { controller = "CrossDomain", policyId = 1 });

//http://searchcode.com/codesearch/view/20725090
//http://blog.cyplo.net/tag/net/
//http://www.hanselman.com/blog/ProjectlessScriptedCWithScriptCSAndRoslyn.aspx
//http://www.asp.net/web-api/overview/hosting-aspnet-web-api/self-host-a-web-api
//http://www.piotrwalat.net/hosting-web-api-in-windows-service/