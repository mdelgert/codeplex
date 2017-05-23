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

using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace Base.Network
{
    /// <summary>
    /// Client utilities 
    /// </summary>
    public class ClientHelper
    {
        public string GetLocalIP() //using System.Net; -- http://stackoverflow.com/questions/6668810/how-do-i-determine-the-local-hosts-ipv4-addresses
        {
            /// <summary>
            /// Returns client local active IPV4 ipaddress example: 192.168.0.20
            /// </summary>
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

        public void PrintIPAddresses()
        {
            /// <summary>
            /// Loops and prints all local addresses
            /// </summary>
            //http://stackoverflow.com/questions/151231/how-do-i-get-the-local-network-ip-address-of-a-computer-programmatically-c
            string sHostName = Dns.GetHostName();
            IPHostEntry ipE = Dns.GetHostByName(sHostName);
            IPAddress[] IpA = ipE.AddressList;
            for (int i = 0; i < IpA.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, IpA[i].ToString());
            }
        }

        public string IpBase()
        {
            /// <summary>
            /// Loops and prints network scan ipbase
            /// </summary>

            var nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();
            string ipBase = nic.GetIPProperties().GatewayAddresses.FirstOrDefault().Address.ToString();
            return ipBase.Substring(0, ipBase.Length - 1);

        }

        public void PrintFullAddress()
        {
            //http://stackoverflow.com/questions/151231/how-do-i-get-the-local-network-ip-address-of-a-computer-programmatically-c
            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                Console.WriteLine("Network Interface: {0}", netif.Name);
                IPInterfaceProperties properties = netif.GetIPProperties();
                foreach (IPAddress dns in properties.DnsAddresses)
                    Console.WriteLine("\tDNS: {0}", dns);
                foreach (IPAddressInformation anycast in properties.AnycastAddresses)
                    Console.WriteLine("\tAnyCast: {0}", anycast.Address);
                foreach (IPAddressInformation multicast in properties.MulticastAddresses)
                    Console.WriteLine("\tMultiCast: {0}", multicast.Address);
                foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                    Console.WriteLine("\tUniCast: {0}", unicast.Address);
            }
        }

        public void PrintHostInfo()
        {
            //http://stackoverflow.com/questions/151231/how-do-i-get-the-local-network-ip-address-of-a-computer-programmatically-c
            //http://msdn.microsoft.com/en-us/library/vstudio/system.net.networkinformation.ipinterfaceproperties
            //http://stackoverflow.com/questions/13634868/get-the-default-gateway
            //http://stackoverflow.com/questions/18551686/how-do-you-get-hosts-broadcast-address-of-the-default-network-adapter-c-sharp

            //Method 1
            var nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

            Console.WriteLine("Gateway=" + nic.GetIPProperties().GatewayAddresses.FirstOrDefault().Address);
            Console.WriteLine("DNS=" + nic.GetIPProperties().DnsAddresses.FirstOrDefault());
            Console.WriteLine("MAC=" + nic.GetPhysicalAddress().ToString());
            Console.WriteLine("IP=" + nic.GetIPProperties().UnicastAddresses.FirstOrDefault().Address);
            Console.WriteLine("Subnet=" + nic.GetIPProperties().UnicastAddresses.FirstOrDefault().IPv4Mask);

            //Method 2
            //NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //foreach (NetworkInterface Interface in Interfaces)
            //{
            //    if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
            //    if (Interface.OperationalStatus != OperationalStatus.Up) continue;
            //    Console.WriteLine(Interface.Description);
            //    UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
            //    foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
            //    {
            //        if (UnicatIPInfo.IPv4Mask.ToString() != "0.0.0.0")
            //        {
            //            Console.WriteLine("\tIP Address is {0}", UnicatIPInfo.Address);
            //            Console.WriteLine("\tSubnet Mask is {0}", UnicatIPInfo.IPv4Mask);
            //        }

            //    }
            //}

        }

    }

}