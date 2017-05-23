using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;

namespace BaseConsoleApplicationSelHostMono
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 
            // for more information.

            string url = "http://localhost:8080";

            //string url = "http://192.168.1.197:8080";

            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }

    }

    class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    app.UseCors(CorsOptions.AllowAll);
        //    app.MapSignalR();
        //}

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.Map("/raw-connection", map =>
            {
                // Turns cors support on allowing everything
                // In real applications, the origins should be locked down
                map.UseCors(CorsOptions.AllowAll)
                   .RunSignalR<RawConnection>();
            });

            app.Map("/signalr", map =>
            {
                var config = new HubConfiguration
                {
                    // You can enable JSONP by uncommenting this line
                    // JSONP requests are insecure but some older browsers (and some
                    // versions of IE) require JSONP to work cross domain
                    // EnableJSONP = true
                };

                // Turns cors support on allowing everything
                // In real applications, the origins should be locked down
                map.UseCors(CorsOptions.AllowAll)
                   .RunSignalR(config);
            });

            // Turn tracing on programmatically
            GlobalHost.TraceManager.Switch.Level = SourceLevels.Information;
        }

    }
    public class MyHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);

            Console.WriteLine("Message receive:" + message);

        }

        public void AddMessage(string name, string message)
        {
            Console.WriteLine("Hub AddMessage {0} {1}\n", name, message);
            Clients.All.addMessage(name, message);
        }

        public void Heartbeat()
        {
            Console.WriteLine("Hub Heartbeat\n");
            Clients.All.heartbeat();
        }

        public void SendHelloObject(HelloModel hello)
        {
            Console.WriteLine("Hub hello {0} {1}\n", hello.Molly, hello.Age);
            Clients.All.sendHelloObject(hello);
        }

        public override Task OnConnected()
        {
            Console.WriteLine("Hub OnConnected {0}\n", Context.ConnectionId);
            return (base.OnConnected());
        }

        public override Task OnDisconnected()
        {
            Console.WriteLine("Hub OnDisconnected {0}\n", Context.ConnectionId);
            return (base.OnDisconnected());
        }

        public override Task OnReconnected()
        {
            Console.WriteLine("Hub OnReconnected {0}\n", Context.ConnectionId);
            return (base.OnDisconnected());
        }

    }

    public class HelloModel
    {
        public string Molly { get; set; }

        public int Age { get; set; }
    }
}
