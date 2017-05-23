using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudBackupScheduler.ClientWindowsFormsApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = AssemblyTitle;
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppExit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void AppExit()
        {
            notifyIcon1.Dispose();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.txtBackupPath.Text = this.folderBrowserDialog1.SelectedPath.ToString();
        }

        private void btnArchivePath_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            string f = String.Format("{0:MdyyyyHHmmss}", dt);
            this.folderBrowserDialog1.ShowDialog();
            this.txtArchivePath.Text = this.folderBrowserDialog1.SelectedPath.ToString() + "\\" + f + ".7z"; ;
        }

    }
}
