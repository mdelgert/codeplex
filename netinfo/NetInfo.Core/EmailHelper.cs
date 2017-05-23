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
using System.Configuration;
using System.Net.Configuration;
using System.Web;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Net.Mail;

namespace NetInfo.Core
{

    public class EmailHelper
    {

        public void SendLog()
        {

            //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration("SQLBackupFTP.exe");
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration("NetInfo.ConsoleApplication.exe");

            MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");

            string toAddress = "mdelgert@yahoo.com";
            string fromAddress = settings.Smtp.Network.UserName;
            string subject = "SOME SUBJECT";
            string messageBody = "MESSAGE BODY";
            bool IsHtml = false;
            bool HasMailRelay = false;
            bool HasMailSettings = true;

            if (toAddress != null)
            {
                try
                {
                    
                    if (toAddress != fromAddress & HasMailSettings == true)
                    {
                        MailMessage message = new MailMessage();
                        message.From = new System.Net.Mail.MailAddress(settings.Smtp.Network.UserName.ToString());
                        message.To.Add(new MailAddress(toAddress));
                        message.Subject = subject;
                        message.IsBodyHtml = IsHtml;
                        message.Body = messageBody;
                        SmtpClient client = new SmtpClient();

                        client.EnableSsl = true;

                        client.Send(message);
                        //client.Dispose();
                    }

                    if ((toAddress == fromAddress & HasMailRelay == true) | (HasMailRelay == true & HasMailSettings == false))
                    {
                        //Gmail server has a bug that does not allow send to address from the same address in this case send through an open mail relay
                        MailMessage message = new MailMessage();
                        message.From = new System.Net.Mail.MailAddress(fromAddress);
                        message.To.Add(new MailAddress(toAddress));
                        message.Subject = subject;
                        message.IsBodyHtml = IsHtml;
                        message.Body = messageBody;
                        SmtpClient client = new SmtpClient();
                        
                        client.Host = ConfigurationManager.AppSettings["SMTPRelayHost"];
                        
                        client.Port = int.Parse(ConfigurationManager.AppSettings["SMTPRelayPort"]);
                        
                        //client.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["SMTPRelayEnableSsl"]);

                        client.Send(message);
                        //client.Dispose();
                    }

                    if (HasMailRelay == false & HasMailSettings == false)
                    {
                        //Log.Msg("Send log file to " + toAddress + " failed please check mail settings");
                    }

                }
                catch (Exception ex)
                {
                    //Log.Msg("Send log file to " + toAddress + " failed please check mail settings", true);
                    //Log.Msg(ex.ToString(), true);
                }

            }

        }

    }

}
