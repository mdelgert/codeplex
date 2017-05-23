﻿/*  
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
using System.Net;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Threading;

namespace NetInfo.Core
{
    
    public class PingHelper
    {

        LogHelper L = new LogHelper();

        //http://msdn.microsoft.com/en-us/library/system.net.networkinformation.ping.aspx

        public void PingServer(string ServerName)
        {

            AutoResetEvent waiter = new AutoResetEvent(false);

            Ping pingSender = new Ping();

            // When the PingCompleted event is raised, 
            // the PingCompletedCallback method is called.
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

            // Create a buffer of 32 bytes of data to be transmitted. 
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 12 seconds for a reply. 
            int timeout = 12000;

            // Set options for transmission: 
            // The data can go through 64 gateways or routers 
            // before it is destroyed, and the data packet 
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            //Console.WriteLine("Time to live: {0}", options.Ttl);
            L.WriteLog("Time to live: " + options.Ttl);

            //Console.WriteLine("Don't fragment: {0}", options.DontFragment);
            L.WriteLog("Don't fragment:" + options.DontFragment);

            L.WriteLog("Pinging host " + ServerName);

            // Send the ping asynchronously. 
            // Use the waiter as the user token. 
            // When the callback completes, it can wake up this thread.
            pingSender.SendAsync(ServerName, timeout, buffer, options, waiter);

            // Prevent this example application from ending. 
            // A real application should do something useful 
            // when possible.
            waiter.WaitOne();
            
            //Console.WriteLine("Ping example completed.");

        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            // If the operation was canceled, display a message to the user. 
            if (e.Cancelled)
            {
                Console.WriteLine("Ping canceled.");

                // Let the main thread resume.  
                // UserToken is the AutoResetEvent object that the main thread  
                // is waiting for.
                ((AutoResetEvent)e.UserState).Set();
            }

            // If an error occurred, display the exception to the user. 
            if (e.Error != null)
            {
                
                //Console.WriteLine("Ping failed:");
                L.WriteLog("Ping failed:");

                //Console.WriteLine(e.Error.ToString());
                L.WriteLog(e.Error.ToString());

                // Let the main thread resume. 
                ((AutoResetEvent)e.UserState).Set();
            }

            PingReply reply = e.Reply;

            DisplayReply(reply);

            // Let the main thread resume.
            ((AutoResetEvent)e.UserState).Set();
        }

        public void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            //Console.WriteLine("ping status: {0}", reply.Status);
            L.WriteLog("ping status: " + reply.Status);

            if (reply.Status == IPStatus.Success)
            {
                //Console.WriteLine("Address: {0}", reply.Address.ToString());
                L.WriteLog("Address: " + reply.Address.ToString());
                
                //Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                L.WriteLog("RoundTrip time: " + reply.RoundtripTime);

                //Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                L.WriteLog("Time to live: " + reply.Options.Ttl);

                //Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                L.WriteLog("Don't fragment: " + reply.Options.DontFragment);

                //Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                L.WriteLog("Buffer size: " + reply.Buffer.Length);

            }

        }

    }

}
