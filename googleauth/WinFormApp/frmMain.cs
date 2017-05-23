using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.GoogleAuth;

namespace WinFormApp
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string PasswordSalt = ConfigurationManager.AppSettings.Get("PasswordSalt");
            //string User = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("User"), PasswordSalt);
            //string Pass = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("Pass"), PasswordSalt);

            //using (AuthService.Service1Client client = new AuthService.Service1Client())
            //{
            //    txtToken.Text = client.GetKey(User, Pass);
            //    client.Close();
            //}

            txtToken.Text = BLL.GoogleAuth.Generator.GetToken();
            lblTokenName.Text = ConfigurationManager.AppSettings.Get("TokenName");

            const int Interval = 30;
            int Progress;
            int Secound = int.Parse(DateTime.Now.Second.ToString());

            if (Secound >= Interval)
            {
                Secound = Secound - Interval;
            }

            Progress = Interval - Secound;

            progressBar1.Value = Progress;

            if (Secound > Interval - 5)
            {
                txtToken.ForeColor = Color.Red;
                progressBar1.ForeColor = Color.Red;
            }
            else
            {
                txtToken.ForeColor = Color.FromArgb(60, 83, 150);
                progressBar1.ForeColor = Color.FromArgb(60, 83, 150);
            }

            //System.Diagnostics.Debug.WriteLine("Progress Value:" + Progress.ToString());

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtToken.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://googleauth.codeplex.com/");
        }

    }

}
