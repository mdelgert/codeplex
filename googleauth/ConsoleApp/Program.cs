/*  
 *  Copyright © 2012 Matthew David Elgert - mdelgert@yahoo.com
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation; either version 2.1 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with this program; if not, write to the Free Software
 *  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA 
 * 
 * URLS
 * http://stackoverflow.com/questions/186084/how-do-you-add-a-timer-to-a-c-sharp-console-application
 *  Project URL: http://googleauth.codeplex.com/                           
 *  
 */

using System;
using System.Reflection;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    public class Program
    {

        static void Main()
        {
            TimerCallback callback = new TimerCallback(Tick);
            Timer stateTimer = new Timer(callback, null, 0, 1000);
            for (; ; ) { } // loop forever
        }

        static public void Tick(Object stateInfo)
        {

            const int Interval = 30;
            int Progress;
            int Secound = int.Parse(DateTime.Now.Second.ToString());

            if (Secound >= Interval)
            {
                Secound = Secound - Interval;
            }

            Progress = Interval - Secound;

            StringBuilder sb = new StringBuilder();

            int count = 1;

            while (count < Progress)
            {
                sb.Append("|");
                count++;
            }

            string Token;

            //string PasswordSalt = ConfigurationManager.AppSettings.Get("PasswordSalt");
            //string User = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("User"), PasswordSalt);
            //string Pass = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("Pass"), PasswordSalt);
            
            //using (AuthService.Service1Client client = new AuthService.Service1Client())
            //{
            //    Token = client.GetKey(User, Pass);    
            //    client.Close();
            //}

            Token = BLL.GoogleAuth.Generator.GetToken();

            if (Secound > Interval - 5)
            {
                ShowHeader(false);
            }
            else
            {
                ShowHeader(true);
            }
            Console.WriteLine("Token:" + Token);
            Console.WriteLine("Name:" + ConfigurationManager.AppSettings.Get("TokenName"));
            Console.WriteLine(sb.ToString());

        }

        public static void ShowHeader(bool ColorDefault = true)
        {
            if (ColorDefault)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Copyright (C) Matthew David Elgert 2012");
            Console.WriteLine("GoogleAuth version " + GetAssemblyVersion());
            Console.WriteLine();
            Console.WriteLine("http://googleauth.codeplex.com/");
            Console.WriteLine("mdelgert@yahoo.com");
            Console.WriteLine();
            Console.WriteLine("");
        }

        private static string GetAssemblyVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

    }

}
