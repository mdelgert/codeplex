using System;
using System.IO;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.SelfHost;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
                "Default", "{controller}/{action}",
                new { controller = "Home", action = "Index" });

            string viewPathTemplate = "SelfHost.Views.{0}";

            TemplateServiceConfiguration templateConfig = new TemplateServiceConfiguration();
            templateConfig.Resolver = new DelegateTemplateResolver(name =>
            {
                string resourcePath = string.Format(viewPathTemplate, name);
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            });
            Razor.SetTemplateService(new TemplateService(templateConfig));

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();

                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
