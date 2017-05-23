using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScreenMate
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://screenmate.codeplex.com/");
            Process.Start(sInfo);
        }
    }
}
