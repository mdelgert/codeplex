using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VESSEA.Core.Buisness;

namespace VESSEA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEGIN:");

            var a = new CRUDApplicationLog();

            a.Create("TEST1");
            a.Create("TEST2");

            a.ReadRows();

            Console.WriteLine("END:");
            Console.ReadKey();
        }
    }
}
