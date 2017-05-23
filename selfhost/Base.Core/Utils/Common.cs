﻿/*  
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
 *  Project URL: http://selfhost.codeplex.com/
 *  License URL: http://selfhost.codeplex.com/license 
 *  
 */

using System;
using System.Text;
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
            Console.WriteLine(GetLicense());
        }

        public static string GetLicense()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Version " + GetAssemblyVersion() + " Copyright (C) Matthew David Elgert mdelgert@yahoo.com, All Rights Reserved." + Environment.NewLine);
            sb.Append("Project URL: http://selfhost.codeplex.com" + Environment.NewLine);
            sb.Append("License URL: http://selfhost.codeplex.com/license" + Environment.NewLine + Environment.NewLine);
            sb.Append(@"GNU General Public License version 3 (GPLv3)" + Environment.NewLine + Environment.NewLine);
            sb.Append(@"Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"The licenses for most software and other practical works are designed to take away your freedom to share and change the works. By contrast, the GNU General Public License is intended to guarantee your freedom to share and change all versions of a program--to make sure it remains free software for all its users. We, the Free Software Foundation, use the GNU General Public License for most of our software; it applies also to any other work released this way by its authors. You can apply it to your programs, too." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"When we speak of free software, we are referring to freedom, not price. Our General Public Licenses are designed to make sure that you have the freedom to distribute copies of free software (and charge for them if you wish), that you receive source code or can get it if you want it, that you can change the software or use pieces of it in new free programs, and that you know you can do these things." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"To protect your rights, we need to prevent others from denying you these rights or asking you to surrender the rights. Therefore, you have certain responsibilities if you distribute copies of the software, or if you modify it: responsibilities to respect the freedom of others." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"For example, if you distribute copies of such a program, whether gratis or for a fee, you must pass on to the recipients the same freedoms that you received. You must make sure that they, too, receive or can get the source code. And you must show them these terms so they know their rights." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"Developers that use the GNU GPL protect your rights with two steps: (1) assert copyright on the software, and (2) offer you this License giving you legal permission to copy, distribute and/or modify it.");
            sb.Append(@"For the developers' and authors' protection, the GPL clearly explains that there is no warranty for this free software. For both users' and authors' sake, the GPL requires that modified versions be marked as changed, so that their problems will not be attributed erroneously to authors of previous versions." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"Some devices are designed to deny users access to install or run modified versions of the software inside them, although the manufacturer can do so. This is fundamentally incompatible with the aim of protecting users' freedom to change the software. The systematic pattern of such abuse occurs in the area of products for individuals to use, which is precisely where it is most unacceptable. Therefore, we have designed this version of the GPL to prohibit the practice for those products. If such problems arise substantially in other domains, we stand ready to extend this provision to those domains in future versions of the GPL, as needed to protect the freedom of users." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"Finally, every program is threatened constantly by software patents. States should not allow patents to restrict development and use of software on general-purpose computers, but in those that do, we wish to avoid the special danger that patents applied to a free program could make it effectively proprietary. To prevent this, the GPL assures that patents cannot be used to render the program non-free." + Environment.NewLine + Environment.NewLine);
            sb.Append(@"The precise terms and conditions for copying, distribution and modification follow." + Environment.NewLine + Environment.NewLine);

            return sb.ToString();
        }

        private static string GetAssemblyVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
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

        public static string HostAddress()
        {

            bool useHostBaseAddress = AppSettingsCfg.GetUseHostBaseAddressKey();
            bool useHostBasePort = AppSettingsCfg.GetUseHostBasePortKey();
            string hostAddress = AppSettingsCfg.GetHostBaseAddressKey();
            string hostBasePort = AppSettingsCfg.GetHostBasePortKey();
            string host = null;

            if (!useHostBaseAddress)
            {
                host = "http://" + Common.GetLocalIP();
            }
            else
            {
                host = hostAddress;
            }

            if (!useHostBasePort)
            {
                host = host + ":80";
            }
            else
            {
                host = host + ":" + hostBasePort;
            }

            return host;

        }

    }

}