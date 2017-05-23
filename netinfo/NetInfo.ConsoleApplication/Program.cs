/*  
 *  Copyright © 2013 Matthew David Elgert - mdelgert@yahoo.com
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
 *  Project URL: http://netinfo.codeplex.com                      
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;
using NetInfo.Core;
using System.Diagnostics;
using System.Threading;

//4.5 framework trying to build with lowest framework possible
//using System.Linq;
//using System.Threading.Tasks;

namespace NetInfo.ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            
            LogHelper L = new LogHelper();
            //L.WriteLog("BEGIN:");

            PingHelper P = new PingHelper();

            for (int i = 0; i < 5; i++) //http://social.msdn.microsoft.com/Forums/en/netfxbcl/thread/f06a12ec-3d30-40db-b7cd-6f898d2ec6dc
            {

                var stopwatch = Stopwatch.StartNew(); //http://www.dotnetperls.com/sleep
                Thread.SpinWait(100000 * 10000);
                //P.PingServer("10.0.0.5");
                P.PingServer("VSRV1");
                //P.PingServer("VSRV2");
                P.PingServer("CICSBOX");

                //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }

            //EmailHelper E = new EmailHelper();

            //E.SendLog();

            //L.WriteLog("END:");

            Console.ReadKey();

        }

    }

}
