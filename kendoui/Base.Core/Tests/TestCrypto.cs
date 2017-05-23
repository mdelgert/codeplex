using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Core.Utils;

namespace Base.Core.Tests
{
    public class TestCrypto
    {
        readonly Crypto c = new Crypto();
        LoremIpsumGen l = new LoremIpsumGen();

        public void RunTests(int testsCount)
        {
            for (int i = 1; i <= testsCount; i++)
            {
                c.GenerateRandomPassphrase();

                //string passVal = "Noth!sP@ssw0rd2014#%" + i.ToString();
                string passVal = passVal = l.GenRandomWord();

                Console.WriteLine("PassVal=" + passVal);

                string passSalt = c.GenerateRandomPassphrase();
                Console.WriteLine("PassSalt=" + passSalt);

                passVal = c.Encrypt(passVal, passSalt);
                Console.WriteLine("Encrypted PassVal=" + passVal);

                passVal = c.Decrypt(passVal, passSalt);
                Console.WriteLine("Decrypted PassVal=" + passVal);

            }

        }


    }

}
