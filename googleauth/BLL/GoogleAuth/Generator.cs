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
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace BLL.GoogleAuth
{

    public static class Generator
    {
        #region Properties

        private static Token generator;

        private static Token _Generator
        {
            get
            {
                if (generator == null)
                {
                    generator = new Token();
                }

                return generator;
            }
        }

        private static Configuration config;

        private static Configuration Config
        {
            get
            {
                if (config == null)
                {
                    config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                }

                return config;
            }
        }

        #endregion Properties

        public static string GetToken()
        {
            string Token = null;
            try
            {
                _Generator.SetPassword(ConfigurationManager.AppSettings.Get("AuthPassKey"));
                Token = _Generator.GenerateTimeoutCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return Token;
        }

        public static string GetPreviousToken()
        {
            string Token = null;
            try
            {
                _Generator.SetPassword(ConfigurationManager.AppSettings.Get("AuthPassKey"));
                Token = _Generator.GenerateTimeoutCode(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return Token;
        }

        public static string GetNextToken()
        {
            string Token = null;
            try
            {
                _Generator.SetPassword(ConfigurationManager.AppSettings.Get("AuthPassKey"));
                Token = _Generator.GenerateTimeoutCode(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine("Invalid key - please re-enter");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return Token;
        }

        public static bool TokenValid(string Token)
        {
            bool Valid;

            if (Token == GetToken() | Token == GetPreviousToken() | Token == GetNextToken()) //Allow forgiveness in some cases processors are slower behind one token some processors are fast one token ahead
                Valid = true;
            else
                Valid = false;

            return Valid;
        }

    }

}
