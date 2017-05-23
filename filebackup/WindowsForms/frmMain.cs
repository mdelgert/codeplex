using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SevenZip;

namespace FileBackup
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtBackupPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void btnArchivePath_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            string f = String.Format("{0:MdyyyyHHmmss}", dt);
            folderBrowserDialog1.ShowDialog();
            txtArchivePath.Text = folderBrowserDialog1.SelectedPath.ToString() + "\\" + f + ".7z";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup();
        }

        private void Backup()
        {
            string scheduler = String.Format("{0:M/d/yyyy}", dateTimePicker1.Value.ToShortDateString()) + " " + String.Format("{0:t}", dateTimePicker2.Value.ToShortTimeString());
            BLL.AppUtils.SaveAppSettings(txtStorageAccount.Text.ToString(), txtStorageKey.Text.ToString(), txtBackupPath.Text.ToString(), txtArchivePath.Text.ToString(), txtArchivePassword.Text.ToString(), scheduler.ToString(), chkWindowsAzure.Checked.ToString());

            SevenZipCompressor tmp = new SevenZipCompressor();
            tmp.Compressing += new EventHandler<ProgressEventArgs>(cmp_Compressing);
            tmp.FileCompressionStarted += new EventHandler<FileNameEventArgs>(cmp_FileCompressionStarted);
            tmp.CompressionFinished += new EventHandler<EventArgs>(cmp_CompressionFinished);
            tmp.ZipEncryptionMethod = ZipEncryptionMethod.Aes256;
            tmp.BeginCompressDirectory(txtBackupPath.Text.ToString(), txtArchivePath.Text.ToString(), txtArchivePassword.Text.ToString());

            if (chkWindowsAzure.Checked)
            {
                BLL.AzureBackup.Backup(txtStorageAccount.Text.ToString(), txtStorageKey.Text.ToString(), txtArchivePath.Text.ToString(), "MatthewTest.7z");
            }

        }

        void cmp_Compressing(object sender, ProgressEventArgs e)
        {
            pb_CompressProgress.Increment(e.PercentDelta);
        }

        void cmp_FileCompressionStarted(object sender, FileNameEventArgs e)
        {
            l_CompressProgress.Text = String.Format("Compressing \"{0}\"", e.FileName);
        }

        void cmp_CompressionFinished(object sender, EventArgs e)
        {
            l_CompressProgress.Text = "Finished";
            pb_CompressProgress.Value = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            if (File.Exists("AppSettings.xml"))
            {
                //http://stackoverflow.com/questions/55828/best-practices-to-parse-xml-files
                XmlDocument xmlDoc = new XmlDocument(); //* create an xml document object.
                xmlDoc.Load("AppSettings.xml"); //* load the XML document from the specified file.
                txtStorageAccount.Text = BLL.Crypto.Decrypt(xmlDoc.SelectSingleNode("AppSettings/StorageAccount").InnerXml.ToString(), BLL.AppUtils.GetMacAddress());
                txtStorageKey.Text = BLL.Crypto.Decrypt(xmlDoc.SelectSingleNode("AppSettings/StorageKey").InnerXml.ToString(), BLL.AppUtils.GetMacAddress());
                txtBackupPath.Text = xmlDoc.SelectSingleNode("AppSettings/BackupPath").InnerXml.ToString();
                txtArchivePath.Text = xmlDoc.SelectSingleNode("AppSettings/ArchivePath").InnerXml.ToString();
                txtArchivePassword.Text = xmlDoc.SelectSingleNode("AppSettings/ArchivePassword").InnerXml.ToString();
                dateTimePicker1.Value = DateTime.Parse(xmlDoc.SelectSingleNode("AppSettings/Scheduler").InnerXml.ToString());
                dateTimePicker2.Value = DateTime.Parse(xmlDoc.SelectSingleNode("AppSettings/Scheduler").InnerXml.ToString());
                chkWindowsAzure.Checked = bool.Parse(xmlDoc.SelectSingleNode("AppSettings/WindowsAzureBackup").InnerXml.ToString()); 
            }
            else
            {
                txtStorageAccount.Text = "YOUR STORAGE ACCOUNT";
                txtStorageKey.Text = "YOUR STORAGE KEY";
                txtBackupPath.Text = "SELECT";
                txtArchivePath.Text = "SELECT";
                txtArchivePassword.Text = "PASSWORD";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppExit();
        }

        public void AppExit()
        {
            notifyIcon1.Dispose();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string scheduler = String.Format("{0:M/d/yyyy}", dateTimePicker1.Value.ToShortDateString()) + " " + String.Format("{0:t}", dateTimePicker2.Value.ToShortTimeString());
            DateTime dt = DateTime.Parse(scheduler);

            //if (DateTime.Now > dt)
            //{
            //    Backup();
            //    timer1.Enabled = false;
            //}

        }

    }
}
