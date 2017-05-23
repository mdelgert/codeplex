using System;
using System.Reflection;
using System.Linq;
using System.Net;

namespace Base.Core.Utils
{
    public class Common
    {
        public static void ShowHeaderBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            PrintCopyright();
            Console.WriteLine("Version " + GetAssemblyVersion() + " Copyright (C) Matthew David Elgert mdelgert@hotmail.com, All Rights Reserved.");
            Console.WriteLine();
        }

        public static void ShowHeaderGreen()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            PrintCopyright();
            Console.WriteLine("Version " + GetAssemblyVersion() + " Copyright (C) Matthew David Elgert mdelgert@hotmail.com, All Rights Reserved.");
            Console.WriteLine();
        }

        public static void ShowHeaderMagenta()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            PrintCopyright();
            Console.WriteLine("Version " + GetAssemblyVersion() + " Copyright (C) Matthew David Elgert mdelgert@hotmail.com, All Rights Reserved.");
            Console.WriteLine();
        }

        private static string GetAssemblyVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        private static void PrintCopyright()
        {
            Console.WriteLine("* NOTICE: All information contained herein is, and remains the property of Matthew Elgert.");
            Console.WriteLine("* The intellectual and technical concepts contained herein are proprietary to Matthew Elgert");
            Console.WriteLine("* and may be covered by U.S. and Foreign Patents, patents in process, and are protected by");
            Console.WriteLine("* trade secret or copyright law. Dissemination of this information or reproduction of this");
            Console.WriteLine("* material is strictly forbidden unless prior written permission is obtained from Matthew");
            Console.WriteLine("* Elgert. Access to the source code contained herein is hereby forbidden to anyone except");
            Console.WriteLine("* Matthew Elgert or contractors who have executed Confidentiality and Non-disclosure");
            Console.WriteLine("* agreements explicitly covering such access.");
            Console.WriteLine("");
            Console.WriteLine("* The copyright notice above does not evidence any actual or intended publication or");
            Console.WriteLine("* disclosure of this source code, which includes information that is confidential and/or");
            Console.WriteLine("* proprietary, and is a trade secret, of Matthew Elgert. ANY REPRODUCTION, MODIFICATION,");
            Console.WriteLine("* DISTRIBUTION, PUBLIC PERFORMANCE, OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE");
            Console.WriteLine("* WITHOUT THE EXPRESS WRITTEN CONSENT OF Matthew Elgert IS STRICTLY PROHIBITED, AND IN VIOLATION");
            Console.WriteLine("* OF APPLICABLE LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OFTHIS SOURCE CODE");
            Console.WriteLine("* AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS TO REPRODUCE, DISCLOSE OR DISTRIBUTE");
            Console.WriteLine("* ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT ITMAY DESCRIBE, IN WHOLE OR IN PART.");
            Console.WriteLine();
        }

        public static string GetLocalIP() //using System.Net; -- http://stackoverflow.com/questions/6668810/how-do-i-determine-the-local-hosts-ipv4-addresses
        {
            string ipv4Address = String.Empty;

            foreach (IPAddress currentIPAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (currentIPAddress.AddressFamily.ToString() == System.Net.Sockets.AddressFamily.InterNetwork.ToString())
                {
                    ipv4Address = currentIPAddress.ToString();
                    break;
                }
            }

            return ipv4Address;
        }

    }

}
