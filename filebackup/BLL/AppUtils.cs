using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace BLL
{
    public static class AppUtils
    {
        public static string macAddress = GetMacAddress();

        public static void SaveAppSettings(string storageAccount, string storageKey, string backupPath, string archivePath, string archivePassword, string sheduler, string windowsAzure)
        {

            //http://forums.asp.net/t/1440889.aspx/1

            XmlDocument xDoc = new XmlDocument();
            XmlElement xsource;
            XmlElement xTemp;

            xsource = xDoc.CreateElement("AppSettings");
            xDoc.AppendChild(xsource);
            
            xTemp = xDoc.CreateElement("StorageAccount");
            xTemp.InnerText = BLL.Crypto.Encrypt(storageAccount, macAddress);
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("StorageKey");
            xTemp.InnerText = BLL.Crypto.Encrypt(storageKey, macAddress);
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("BackupPath");
            xTemp.InnerText = backupPath;
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("ArchivePath");
            xTemp.InnerText = archivePath;
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("ArchivePassword");
            xTemp.InnerText = archivePassword;
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("Scheduler");
            xTemp.InnerText = sheduler;
            xsource.AppendChild(xTemp);

            xTemp = xDoc.CreateElement("WindowsAzureBackup");
            xTemp.InnerText = windowsAzure.ToString();
            xsource.AppendChild(xTemp);

            xDoc.Save(Directory.GetCurrentDirectory() + "\\AppSettings.xml");

        }

        public static string GetMacAddress()
        {
            var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces() where nic.OperationalStatus == OperationalStatus.Up select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            return macAddr.ToString();
        }

    }

}
