using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Core.Tests;

namespace Base.ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEGIN: Base.ConsoleApplicationTest");

            //TestTaskItemCrud t1 = new TestTaskItemCrud();
            //t1.TestCrud(100);

            //TestTaskItemApi t2 = new TestTaskItemApi();
            //t2.ReadHttpClientTaskItem();
            //t2.RunMany(100);

            //TestLoremIpsumGen t = new TestLoremIpsumGen();
            //t.RunTests(100000);

            //TestCrypto t = new TestCrypto();
            //t.RunTests(100000);

            Console.WriteLine("END: Base.ConsoleApplicationTest");
            Console.ReadKey();
        }

    }

}
