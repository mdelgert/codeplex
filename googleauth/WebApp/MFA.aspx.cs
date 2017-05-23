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
 *  Project URL: http://googleauth.codeplex.com/                           
 *  
 */

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace WebApp
{
    public partial class MFA : System.Web.UI.Page
    {

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string PasswordSalt = ConfigurationManager.AppSettings.Get("PasswordSalt");
            string User = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("User"), PasswordSalt);
            string Pass = BLL.Crypto.Encrypt(ConfigurationManager.AppSettings.Get("Pass"), PasswordSalt);
            string Token = BLL.Crypto.Encrypt(txtToken.Text, PasswordSalt);
            bool IsValid = false;

            //using (AuthService.Service1Client client = new AuthService.Service1Client())
            //{
            //    IsValid = client.ValidToken(User, Pass, Token);
            //    client.Close();
            //}

            IsValid = BLL.GoogleAuth.Generator.TokenValid(txtToken.Text);

            if (IsValid)
            {
                Response.Redirect("LoggedIn.aspx");
            }
            else
            {
                lblMessage.Text = "Token Not valid!";
            }

        }

    }

}