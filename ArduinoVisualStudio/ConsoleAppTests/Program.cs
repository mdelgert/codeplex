using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Base.Core.BusinessLogic;
using Base.Core.EntityDataModel;
using ConsoleAppTests.ArduinoServiceReference; 

namespace ConsoleAppTests
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("BEGIN:");

        //    //Switch o = new Switch();
        //    //SwitchLayer l = new SwitchLayer();
            
        //    //o.SwitchDescription = "Dog door";
        //    //o.SwitchStatus = true;
        //    //l.Create(o);

        //    //o = l.Read(1);
        //    //Console.WriteLine(o.SwitchStatus.ToString());


            

        //    ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();

        //    Console.WriteLine(client.GetStatus().ToString());
            
        //    client.Close();

        //    Console.WriteLine("END:");
        //    Console.ReadKey();
        //}

        private static void Main(string[] args)
        {
            // Create a IPC wait handle with a unique identifier.
            bool createdNew;
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset, "CF2D4313-33DE-489D-9721-6AFF69841DEA", out createdNew);
            var signaled = false;

            // If the handle was already there, inform the other process to exit itself.
            // Afterwards we'll also die.
            if (!createdNew)
            {
                Log("Inform other process to stop.");
                waitHandle.Set();
                Log("Informer exited.");

                return;
            }

            // Start a another thread that does something every 10 seconds.
            var timer = new Timer(OnTimerElapsed, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            // Wait if someone tells us to die or do every five seconds something else.
            do
            {
                signaled = waitHandle.WaitOne(TimeSpan.FromSeconds(5));
                // ToDo: Something else if desired.
            } while (!signaled);

            // The above loop with an interceptor could also be replaced by an endless waiter
            //waitHandle.WaitOne();

            Log("Got signal to kill myself.");
        }

        private static void Log(string message)
        {
            //Console.WriteLine(DateTime.Now + ": " + message);
            ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();

            Console.WriteLine(client.GetStatus().ToString());

        }

        private static void OnTimerElapsed(object state)
        {
            Log("Timer elapsed.");
        }


    }

}
