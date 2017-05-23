using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Core.Utils;

namespace Base.Core.Tests
{
    public class TestLoremIpsumGen
    {
        LoremIpsumGen l = new LoremIpsumGen();

        public void RunTests(int testsCount)
        {

            for (int i = 1; i <= testsCount; i++)
            {
                //Console.WriteLine(l.GenRandomWord());
                //Console.WriteLine(l.GenRandomWord(true, 10));
                //Console.WriteLine(l.GenerateRandomSentance());
                Console.WriteLine(l.GenerateRandomParagraph(false, 5));
                Console.WriteLine("");
            }

        }

    }

}
