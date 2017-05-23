using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Management;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Helpdesk
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            FillNetworkDrivesDropDown();
        }

        public static string[] GetIP4Address()
        {

            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    if (IP4Address.Length == 0)
                    {
                        IP4Address = IPA.ToString();
                    }
                    else
                    {
                        IP4Address = IP4Address + @"," + IPA.ToString();
                    }
                    
                    
                    break;
                }
            }

            return Regex.Split (IP4Address,@",");
        }

        //public static TimeSpan GetUptime()
        //{
        //    ManagementObject mo = new ManagementObject(@"\\.\root\cimv2:Win32_OperatingSystem=@");
        //    DateTime lastBootUp = ManagementDateTimeConverter.ToDateTime(mo["LastBootUpTime"].ToString());
        //    return DateTime.Now.ToUniversalTime() - lastBootUp.ToUniversalTime();
        //}



        //http://stackoverflow.com/questions/972105/retrieve-system-uptime-using-c-sharp

        public static TimeSpan UpTime 
        {
        get {
        using (var uptime = new PerformanceCounter("System", "System Up Time")) {
            uptime.NextValue();       //Call this an extra time before reading its value
            return TimeSpan.FromSeconds(uptime.NextValue());
            }
        }
        }

        public static string GetComputerName()
        {

            string ComputerName = String.Empty;
            ComputerName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");

            return ComputerName;
        }


        public static string GetDefaultPrinterName()
        {

            string Dprinter = string.Empty;

            PrinterSettings settings = new PrinterSettings();

            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                //Dprinter = Dprinter + printer.ToString(); this gets all printers

                settings.PrinterName = printer;

                if (settings.IsDefaultPrinter)
                {
                    Dprinter = printer.ToString();
                }

            }


            return Dprinter;

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string[] IPV4 = GetIP4Address();
            //lblIp.Text = GetIP4Address();
            lblNBName.Text = GetComputerName();
            lblDprinter.Text = GetDefaultPrinterName();
            //listBox1.Items.AddRange(IPV4);
            listBox1.Items.AddRange(IPV4);
            lblUpTime.Text =UpTime.Days.ToString()+ " Days "+ UpTime.Hours.ToString().PadLeft(2, '0') + ":" + UpTime.Minutes.ToString().PadLeft(2, '0') + ":" + UpTime.Seconds.ToString().PadLeft(2, '0');

            //= GetIP4Address();
            //listBox1.Text = GetIP4Address();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (txtbxPwd.Text == "1234")
            {   
                frmAdmin newForm = new frmAdmin();
                newForm.Show();
            }
            
            
            else {MessageBox.Show("Invalid Password");}
            
        }

        private void lblDprinter_Click(object sender, EventArgs e)
        {

        }

        #region MappedNetworkDrivesMethods
        private void button2_Click(object sender, EventArgs e)
        {
            CopyMappedDriveTargetToClipboard(comboBox1.SelectedItem.ToString());
        }

        private void FillNetworkDrivesDropDown()
        {
            var networkDrives = GetNetworkDrives();
            foreach (DriveInfo drive in networkDrives)
            {
                comboBox1.Items.Add(drive.Name);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
        }

        private IEnumerable<DriveInfo> GetNetworkDrives()
        {
            var localDrives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Network);
            return localDrives;
        }

        //http://msdn.microsoft.com/en-us/library/ydby206k.aspx
        private void CopyMappedDriveTargetToClipboard(string selectedDrive)
        {
            string mappedDriveTarget = GetMappedDriveTarget(selectedDrive);
            if (mappedDriveTarget != null)
            {
                System.Windows.Forms.Clipboard.Clear();
                System.Windows.Forms.Clipboard.SetDataObject(mappedDriveTarget);
            }
        }

        string GetMappedDriveTarget(string selectedDrive)
        {
            var networkDrives = GetNetworkDrives();
            foreach (var drive in networkDrives)
            {
                if (drive.Name.ToLower() == selectedDrive.ToLower())
                {
                    ManagementObject mo = new ManagementObject();

                    string driveLetter = GetDriveLetter(drive.Name);

                    mo.Path = new ManagementPath(string.Format("Win32_LogicalDisk='{0}'", driveLetter));
                    string mappedDriveTarget = mo.Properties["ProviderName"].Value.ToString();

                    return mappedDriveTarget;
                }
            }
            return null;
        }

        /// <summary>Given a path will extract just the drive letter with volume separator.</summary>
        /// <param name="pPath"></param>
        /// <returns>C:</returns>
        public string GetDriveLetter(string pPath)
        {
            if (pPath.StartsWith(@"\\")) { throw new ArgumentException("A UNC path was passed to GetDriveLetter"); }
            return Directory.GetDirectoryRoot(pPath).Replace(Path.DirectorySeparatorChar.ToString(), "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mappedNetworkDrive = GetMappedDriveTarget(comboBox1.SelectedItem.ToString());
            if (mappedNetworkDrive != null)
            {
                Process.Start(mappedNetworkDrive);
            }
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtbxPwd.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void txtbxPwd_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //13 = enter
            {
                button1.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUpTime.Text = UpTime.Days.ToString() + " Days " + UpTime.Hours.ToString().PadLeft(2, '0') + ":" + UpTime.Minutes.ToString().PadLeft(2, '0') + ":" + UpTime.Seconds.ToString().PadLeft(2, '0');
        }

    }

}
