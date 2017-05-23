//http://www.lipsum.com/
//http://loremipsumhelper.codeplex.com/SourceControl/latest#RandomStringArrayTool.cs
//https://github.com/alexcpendleton/NLipsum - Very elaberate Lipsum generator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Core.Utils
{
    public class LoremIpsumGen
    {

        /// <summary>
        /// Stores the current random number
        /// </summary>
        static readonly Random _random = new Random();
        private static readonly string[] alphabetArrayUpper = { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] alphabetArrayLower = { string.Empty, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string ipsumStartWith = "Lorem ipsum dolor sit amet.";

        public string GenRandomWord(bool caseLower = true, int wordSize = 0, int wordMaxSize = 12)
        {
            string[] wordArrary;
            StringBuilder sb = new StringBuilder();

            if (wordSize == 0)
            {
                wordSize = _random.Next(1, wordMaxSize);
            }

            if (caseLower)
            {
                wordArrary = RandomizeStrings(alphabetArrayLower);
            }
            else
            {
                wordArrary = RandomizeStrings(alphabetArrayUpper);
            }

            foreach (string value in wordArrary)
            {
                sb.Append(value);
            }

            return sb.ToString().Substring(0, wordSize);
        }

        public string GenerateRandomSentance(bool caseLower = true, int wordCount = 20)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(GenRandomWord(false, 1));
            sb.Append(GenRandomWord());
            wordCount = wordCount - 1;

            for (int i = 1; i <= wordCount; i++)
            {
                sb.Append(" " + GenRandomWord(true, 0));
            }

            sb.Append(".");

            return sb.ToString();
        }

        public string GenerateRandomParagraph(bool startWithLorem = true, int sentanceCount = 5)
        {
            StringBuilder sb = new StringBuilder();

            if (startWithLorem)
            {
                sb.Append(ipsumStartWith);
            }

            for (int i = 1; i <= sentanceCount; i++)
            {
                int wordCount = _random.Next(5, 25);
                sb.Append(" " + GenerateRandomSentance(true, wordCount));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return randomized version of the string array
        /// </summary>
        public string[] RandomizeStrings(string[] arr)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            // Add all strings from array
            // Add new random int each time
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array
            string[] result = new string[arr.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }

    }

}
