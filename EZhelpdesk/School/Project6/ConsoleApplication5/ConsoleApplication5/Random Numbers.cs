/*******************************************************************************
* Programmer: Brad Brundage
* Date: 10-7-2012
* Purpose: Generate 100 random numbers from 0-1000 and display teh following:
* Smallest Number, largest number, range of numbers generated and the number of
* even numbers generated during the process.
* 
********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        { 

            int[] ArrayrandomNums = new int[100];

            for (int i = 0; i < 100; i++)
            {
                ArrayrandomNums[i] = GetRandomNumber(0, 1000, i);
            }

            ////for (int j = 0; j < 100; j++)
            ////{
            ////    //Test random numbers in console
            ////    Console.WriteLine(ArrayrandomNums[j]);
            ////}


            //Write the values out to a message box on seperate lines


            MessageBox.Show("Smallest Number: " + GetSmallest(ArrayrandomNums).ToString() + 
                            "\n" + "Largest Number: " + GetLarges(ArrayrandomNums).ToString() + 
                            "\n" + "Range of Numbers: " + GetSmallest(ArrayrandomNums).ToString() + "-" + GetLarges(ArrayrandomNums).ToString() +  
                            "\n" + "Number Of Even numbers: " + GetCountOfEvens(ArrayrandomNums).ToString());

            //Console.ReadKey();

        }


        static int GetCountOfEvens(int[] randomNums)    //Function to count evens from array
        {
            int Count = 0;

            for (int i = 0; i < randomNums.Length; i++)
            {
                if (randomNums[i] % 2 == 0)
                {
                    //Its even
                    Count++;
                }
                else
                {
                    //Its odd do nothing
                }
            }

            return Count;
        }

        static int GetSmallest(int[] randomNums)
        {
            return randomNums.Min();
        }

        static int GetLarges(int[] randomNums)
        {
            return randomNums.Max();
        }

        static int GetRandomNumber(int min, int max, int seed)
        {
            int Seed = GetRandomSeed(seed);
            Random RandomNumber = new Random(Seed);
            return RandomNumber.Next(min, max);
        }

        static int GetRandomSeed(int seed)
        {
            Random RandomNumber = new Random(DateTime.Now.Millisecond + seed);
            return RandomNumber.Next(0, 1000);
        }

    }

}
