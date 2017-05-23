/*  
 *  Copyright © 2014 Matthew David Elgert - mdelgert@yahoo.com
 *
 *  GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007
 *  
 *  Copyright © 2007 Free Software Foundation, Inc. <http://fsf.org/>
 *
 *  Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed.
 *
 *  The GNU General Public License is a free, copyleft license for software and other kinds of works.
 *  
 *  The licenses for most software and other practical works are designed to take away your freedom to share and change the works. 
 *  By contrast, the GNU General Public License is intended to guarantee your freedom to share and change all versions of a 
 *  program--to make sure it remains free software for all its users. We, the Free Software Foundation, use the GNU General Public 
 *  License for most of our software; it applies also to any other work released this way by its authors. You can apply it to your 
 *  programs, too.
 * 
 * When we speak of free software, we are referring to freedom, not price. Our General Public Licenses are designed to make sure 
 * that you have the freedom to distribute copies of free software (and charge for them if you wish), that you receive source code 
 * or can get it if you want it, that you can change the software or use pieces of it in new free programs, and that you know you 
 * can do these things.
 * 
 * To protect your rights, we need to prevent others from denying you these rights or asking you to surrender the rights. Therefore, 
 * you have certain responsibilities if you distribute copies of the software, or if you modify it: responsibilities to respect the 
 * freedom of others.
 * 
 * For example, if you distribute copies of such a program, whether gratis or for a fee, you must pass on to the recipients the same 
 * freedoms that you received. You must make sure that they, too, receive or can get the source code. And you must show them these 
 * terms so they know their rights.
 * 
 * Developers that use the GNU GPL protect your rights with two steps: (1) assert copyright on the software, and (2) offer you this 
 * License giving you legal permission to copy, distribute and/or modify it.
 * 
 * For the developers' and authors' protection, the GPL clearly explains that there is no warranty for this free software. For both 
 * users' and authors' sake, the GPL requires that modified versions be marked as changed, so that their problems will not be 
 * attributed erroneously to authors of previous versions.
 * 
 * Some devices are designed to deny users access to install or run modified versions of the software inside them, although the 
 * manufacturer can do so. This is fundamentally incompatible with the aim of protecting users' freedom to change the software. The 
 * systematic pattern of such abuse occurs in the area of products for individuals to use, which is precisely where it is most 
 * unacceptable. Therefore, we have designed this version of the GPL to prohibit the practice for those products. If such problems 
 * arise substantially in other domains, we stand ready to extend this provision to those domains in future versions of the GPL, as 
 * needed to protect the freedom of users.
 * 
 * Finally, every program is threatened constantly by software patents. States should not allow patents to restrict development and 
 * use of software on general-purpose computers, but in those that do, we wish to avoid the special danger that patents applied to a 
 * free program could make it effectively proprietary. To prevent this, the GPL assures that patents cannot be used to render the 
 * program non-free.
 * 
 *  Project URL: https://networkscanner.codeplex.com
 *  License URL: https://networkscanner.codeplex.com/license
 *  
 */

//Refernce: http://stackoverflow.com/questions/4042789/how-to-get-ip-all-hosts-in-lan

namespace Base.Network
{

    using System;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Diagnostics;
    using System.Net;
    using System.Threading;
    using System.Net.Sockets;

    /// <summary>
    /// Network ping utilities 
    /// http://stackoverflow.com/questions/4042789/how-to-get-ip-all-hosts-in-lan
    /// </summary>
    /// 
    public class PingHelper
    {

        public void Sweep()
        {

            //http://www.codeproject.com/Articles/25522/Simple-Network-Scanner
            //https://innownsniffer.codeplex.com/
            //https://ipscanner.codeplex.com/

            ClientHelper c = new ClientHelper();

            //Does not run under mono
            //string ipBase = c.IpBase();

            string ipBase = "192.168.1.";

            //http://msdn.microsoft.com/en-us/library/hb7xxkfx(v=vs.110).aspx
            //http://www.codeproject.com/Questions/392870/Find-Computer-Name-Operating-System-name-and-MAC-a
            //http://www.morethantechnical.com/2009/01/26/scanning-your-entire-lan-for-mac-addresses/
            //http://msdn.microsoft.com/en-us/library/system.net.dns.resolve.ASPX
            //http://msdn.microsoft.com/en-us/library/system.net.iphostentry.ASPX
            //http://msdn.microsoft.com/en-us/library/ms143998(v=vs.110).aspx
            //http://www.codeproject.com/Questions/601043/GetplusIPAddressplusandplusComputerplusNameplusofp
            //http://www.codeproject.com/Questions/392870/Find-Computer-Name-Operating-System-name-and-MAC-a

            for (int i = 1; i < 255; i++)
            {
                string ip = ipBase + i.ToString();
                
                //Console.WriteLine(ip);


                // Ping's the local machine.
                Ping pingSender = new Ping();

                //IPAddress address = IPAddress.Loopback;

                PingReply reply = pingSender.Send(ip);

                if (reply.Status == IPStatus.Success)
                {
                    //Console.WriteLine("Address: {0}", reply.Address.ToString());
                    //Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    //Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    //Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    //Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);

                    //Console.WriteLine("Device discovered:" + ip);

                    //Console.WriteLine(System.Net.Dns.GetHostByAddress(ip).HostName.ToString());



                    try
                    {
                        Console.WriteLine(System.Net.Dns.GetHostEntry(ip).HostName);
                    }
                    catch
                    {
                        Console.WriteLine("Device discovered:" + ip);
                    }


                }
                else
                {
                    //Console.WriteLine(reply.Status);
                    //Do nothing
                }



            }

        }

        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;

        public void Sweep2()
        {

            //Tested on mono Async operations appear working

            //http://stackoverflow.com/questions/4042789/how-to-get-ip-all-hosts-in-lan
            ClientHelper c = new ClientHelper();
            //string ipBase = c.IpBase();
            string ipBase = "192.168.1.";

            countdown = new CountdownEvent(1);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i < 255; i++)
            {
                string ip = ipBase + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                countdown.AddCount();

                //p.SendAsync(ip, 100, ip);
                p.SendAsync(ip, 4000, ip);
                //p.SendAsync(ip, 9000, ip);

            }
            countdown.Signal();
            countdown.Wait();
            sw.Stop();
            TimeSpan span = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
            Console.ReadLine();
        }

        static void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                if (resolveNames)
                {
                    string name;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException ex)
                    {
                        name = "?";
                    }
                    Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                }
                else
                {
                    Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                }
                lock (lockObj)
                {
                    upCount++;
                }
            }
            else if (e.Reply == null)
            {
                Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
            }
            countdown.Signal();
        }

    }

}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Net.NetworkInformation;
//using System.Diagnostics;
//using System.Net;
//using System.Threading;
//using System.Net.Sockets;