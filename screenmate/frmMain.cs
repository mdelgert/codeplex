/*  
 *  Copyright © 2012 Matthew David Elgert - mdelgert@yahoo.com
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
 *  Project URL: http://screenmate.codeplex.com/                          
 *  
 */

using System;
using System.Threading;
using System.Media;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ScreenMate
{
    public partial class frmMain : Form
    {



        //PointX is the horizontal ---
        //PointY is the verticle |

        int PointX = 0, PointY = 0, DirectionX = 0, DirectionY = 0, FormWidth = 0, FormHeight = 0, ScreenWidth = 0, ScreenHeight = 0;
        bool SoundOff = false;

        public frmMain()
        {
            InitializeComponent();
            ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {

            //http://support.microsoft.com/kb/319292
            Assembly _assembly;
            Stream _imageStream;
            _assembly = Assembly.GetExecutingAssembly();

            if (DirectionX == 0)
            {
                _imageStream = _assembly.GetManifestResourceStream("ScreenMate.Resources.Starships.Borg.Right.gif");
            }
            else
            {
                _imageStream = _assembly.GetManifestResourceStream("ScreenMate.Resources.Starships.Borg.Left.gif");
            }

            //Set form size dynamically by picture size
            if (FormWidth == 0 & FormHeight == 0)
            {
                System.Drawing.Image objImage = System.Drawing.Image.FromStream(_imageStream);
                FormWidth = objImage.Width;
                FormHeight = objImage.Height;
                frmMain.ActiveForm.Width = ScreenWidth;
                frmMain.ActiveForm.Height = ScreenHeight;
            }

            if (PointX == 0)
            {
                PointX = Program.RandomNumber(1, ScreenHeight);
            }

            if (PointY == 0)
            {
                PointY = Program.RandomNumber(1, ScreenWidth);
            }

            int[] values = new int[4];
            values = Program.GetCordinates1(ScreenWidth, ScreenHeight, PointX, PointY, DirectionX, DirectionY);
            PointX = values[0];
            PointY = values[1];
            DirectionX = values[2];
            DirectionY = values[3];

            BoxScreenMate.Image = new Bitmap(_imageStream);

            this.Location = new Point(values[0], values[1]);
        }

        private void tmrPlaySound_Tick(object sender, EventArgs e)
        {
            //http://msdn.microsoft.com/en-us/library/4y171b18.aspx
            Assembly _assembly;
            Stream _SoundtStream;
            _assembly = Assembly.GetExecutingAssembly();
            _SoundtStream = _assembly.GetManifestResourceStream(Program.GetSoundClip());
            SoundPlayer simpleSound = new SoundPlayer(_SoundtStream);
            simpleSound.Play();
            tmrPlaySound.Stop();
            //tmrPlaySound.Interval = 25000;
            tmrPlaySound.Start();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tmrPlaySound.Stop();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tmrPlaySound.Start();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //http://stackoverflow.com/questions/4110552/c-sharp-how-do-i-programmatically-create-a-replica-of-my-form
            Form newForm = new frmMain();
            newForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void BoxScreenMate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AppExit();
        }

        private void BoxScreenMate_MouseClick(object sender, MouseEventArgs e)
        {
            tmrMove.Stop();
            //http://support.microsoft.com/kb/319292
            Assembly _assembly;
            Stream _imageStream;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("ScreenMate.Resources.Explosion.BoomLarge1.png");
            System.Drawing.Image objImage = System.Drawing.Image.FromStream(_imageStream);
            FormWidth = objImage.Width;
            FormHeight = objImage.Height;
            frmMain.ActiveForm.Width = ScreenWidth;
            frmMain.ActiveForm.Height = ScreenHeight;
            BoxScreenMate.Image = new Bitmap(_imageStream);
            tmrExit.Interval = 3000;
            tmrExit.Start();
        }

        private void tmrExit_Tick(object sender, EventArgs e)
        {
            AppExit();
        }

        public void AppExit()
        {
            notifyIcon1.Dispose();
            this.Close();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(e.X, e.Y);
        }

        

    }

}
