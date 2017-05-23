//http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client
//http://stackoverflow.com/questions/19448690/how-to-consume-a-webapi-from-asp-net-web-api-to-store-result-in-database
//http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client
//http://stackoverflow.com/questions/16283590/consume-web-api-from-net-console-app
//http://www.codeproject.com/Articles/611176/Calling-ASP-NET-WebAPI-using-HttpClient
//http://www.codeproject.com/Articles/341414/WCF-or-ASP-NET-Web-APIs-My-two-cents-on-the-subjec

using System;
using System.Linq;
using Base.Core.Tests;
using Base.Core.Utils;

namespace Base.ConsoleApplicationClient
{
    class Program
    {

        static void Main(string[] args)
        {
            TestCrypto t1 = new TestCrypto();
            t1.RunTests(1000);

            //TestLoremIpsumGen t = new TestLoremIpsumGen();
            //t.RunTests(100);

            Console.ReadKey();

        }

    }

}

