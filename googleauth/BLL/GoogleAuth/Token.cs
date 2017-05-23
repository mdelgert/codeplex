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
 *  URLS
 *  https://github.com/rdgreen/LCGoogleApps
 *  http://blog.jcuff.net/2011/02/cli-java-based-google-authenticator.html
 *  http://blog.jcuff.net/2011/09/beautiful-two-factor-desktop-client.html
 *  
 *  Project URL: http://googleauth.codeplex.com/                           
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;


namespace BLL.GoogleAuth
{

    public class Token
    {

        private HMACSHA1 Mac { get; set; }
        private int PassCodeLength { get; set; }
        private int Interval { get; set; }
        private int PinModulo { get; set; }

        public Token()
        {
            Mac = new HMACSHA1();
            Interval = 30;
            PassCodeLength = 6;

            PinModulo = (int)Math.Pow(10, PassCodeLength);
        }

        public void SetPassword(string password)
        {
            byte[] key = Base32.FromBase32String(password);
            Mac.Key = key;
        }

        public static string ToHex(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", String.Empty).ToLower();
        }

        public String GenerateTimeoutCode(int OffSet = 0)
        {
            byte[] challenge = Reverse(BitConverter.GetBytes(CurrentInterval + OffSet));
            byte[] hash = Mac.ComputeHash(challenge);
            int offset = hash[hash.Length - 1] & 0xF;
            int result = HashToInt(hash, offset);
            int truncatedHash = result & 0x7FFFFFFF;
            int pinValue = truncatedHash % PinModulo;
            return pinValue.ToString(new String('0', 6));
        }

        private static int HashToInt(byte[] bytes, int start)
        {
            using (BinaryReader input = new BinaryReader(new MemoryStream(bytes, start, bytes.Length - start)))
            {
                byte a = input.ReadByte();
                byte b = input.ReadByte();
                byte c = input.ReadByte();
                byte d = input.ReadByte();
                return ((int)a << 24) | ((int)b << 16) | ((int)c << 8) | (int)d;
            }
        }

        private static byte[] Reverse(byte[] array)
        {
            byte[] result = new byte[array.Length];
            int ix = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[ix++] = array[i];
            }
            return result;
        }

        private static long UnixSeconds(DateTime stamp)
        {
            return (long)(stamp.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
        }

        public long CurrentInterval
        {
            get
            {
                return UnixSeconds(DateTime.Now) / Interval;
            }

        }

    }

}
