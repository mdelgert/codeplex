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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenMate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static int[] GetCordinates1(int ScreenWidth, int ScreenHeight, int PointX, int PointY, int DirectionX, int DirectionY)
        {
            int PointMove = 1;
            int ScreenOffset = 0;
            
            if(PointX == 0)
            {
                ScreenOffset = RandomNumber(10, 1500);
            }

            ScreenWidth = ScreenWidth + ScreenOffset;
            ScreenHeight = ScreenHeight + ScreenOffset;

            int[] values = new int[4];

            //PointX is the horizontal ---
            //PointY is the verticle |

            if (PointX < ScreenWidth * 2)
            {
                PointX = PointX + RandomNumber(1, PointMove);
            }
            else
            {
                PointX = 0;

                if (DirectionX == 0)
                {
                    DirectionX = 1;
                }
                else
                {
                    DirectionX = 0;
                }

            }

            if (PointY < ScreenHeight)
            {
                PointY = PointY + RandomNumber(1, PointMove);
            }
            else
            {
                PointY = 0;

                if (DirectionY == 0)
                {
                    DirectionY = 1;
                }
                else
                {
                    DirectionY = 0;
                }

            }

            values[0] = PointX;
            values[1] = PointY;
            values[2] = DirectionX;
            values[3] = DirectionY;

            return values;

        }

        public static string GetSoundClip()
        {
            int SoundID = RandomNumber(1, 14);
            string SoundClip = "ScreenMate.Resources.SoundClips.";

            //http://www.mediacollege.com/downloads/sound-effects/star-trek/voy/

            switch (SoundID)
            {
                case 1:
                    SoundClip = SoundClip + "tng-computer-2hours.wav";
                    break;
                case 2:
                    SoundClip = SoundClip + "tng-computer-affirmative.wav";
                    break;
                case 3:
                    SoundClip = SoundClip + "tng-computer-programcomplete.wav";
                    break;
                case 4:
                    SoundClip = SoundClip + "tng-computer-transfercomplete.wav";
                    break;
                case 5:
                    SoundClip = SoundClip + "tng-computer-working.wav";
                    break;
                case 6:
                    SoundClip = SoundClip + "tng-data-allsystems.wav";
                    break;
                case 7:
                    SoundClip = SoundClip + "tng-data-beinghailed.wav";
                    break;
                case 8:
                    SoundClip = SoundClip + "tng-data-ihaveaccess.wav";
                    break;
                case 9:
                    SoundClip = SoundClip + "tng-doorbell.wav";
                    break;
                case 10:
                    SoundClip = SoundClip + "tng-locutus-urlifeisover.wav";
                    break;
                case 11:
                    SoundClip = SoundClip + "tng-picard-engage.wav";
                    break;
                case 12:
                    SoundClip = SoundClip + "tng-picard-makeitso.wav";
                    break;
                case 13:
                    SoundClip = SoundClip + "tng-picard-statusreport.wav";
                    break;
                case 14:
                    SoundClip = SoundClip + "tng-worf-incomingmessage.wav";
                    break;

            }

            return SoundClip;

        }

        public static int RandomNumber(int min, int max)
        {
            //http://www.c-sharpcorner.com/uploadfile/mahesh/randomnumber11232005010428am/randomnumber.aspx
            Random random = new Random();
            return random.Next(min, max);
        }
    }

}
