using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Base.Core.Models;

namespace Base.Core.Tests
{
    public class TestTaskItemApi
    {

        public void RunMany(int testsCount)
        {
            for (int i = 1; i <= testsCount; i++)
            {
                ReadHttpClientTaskItem();
                Thread.Sleep(5000);
            }
        }

        public static string Url = "http://kendoui.apphb.com/";
        public static string RemoteApi = "CoreApi/TaskItem";
        public static string FullUrl = Url + RemoteApi;

        public void ReadHttpClientTaskItem()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Add an Accept header for JSON format.

                HttpResponseMessage response = client.GetAsync(RemoteApi).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.ToString());

                    var tasksitems = response.Content.ReadAsAsync<IEnumerable<TaskItem>>().Result;

                    foreach (var t in tasksitems)
                    {
                        Console.WriteLine("KeyId=" + t.KeyId.ToString() + " CreateDate=" + t.CreateDate.ToString() + " TaskName=" + t.TaskName);
                    }

                }
                else
                {
                    Console.WriteLine(response.ToString());
                }

            }

        }

        public void ReadWebRequestTaskItem()
        {

            string request = "http://kendoui.apphb.com/CoreApi/TaskItem";

            Console.WriteLine("Webservice Request Out: ");
            Console.Write(request);

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(request);
            using (HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse())
            {
                using (Stream resStream = response.GetResponseStream())
                {
                    Console.WriteLine(resStream);
                }

            }


        }


    }

}


//http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client
//http://stackoverflow.com/questions/19448690/how-to-consume-a-webapi-from-asp-net-web-api-to-store-result-in-database
//http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client
//http://stackoverflow.com/questions/16283590/consume-web-api-from-net-console-app
//http://www.codeproject.com/Articles/611176/Calling-ASP-NET-WebAPI-using-HttpClient
//http://www.codeproject.com/Articles/341414/WCF-or-ASP-NET-Web-APIs-My-two-cents-on-the-subjec