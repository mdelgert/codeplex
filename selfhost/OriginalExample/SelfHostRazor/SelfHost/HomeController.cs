using System.Net.Http;
using System.Web.Http;
using RazorEngine;
using RazorEngine.Templating;
using System.Net;

namespace SelfHost
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index()
        {
            var model = new { Name = "World", Email = "someone@somewhere.com" };
            string content = new RazorView("Index.cshtml", model).Run();

            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(content, System.Text.Encoding.UTF8, "text/html");
            return response;
        }
    }
}
