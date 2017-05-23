using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class AddContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
        
            BLL.Contacts.Create(
                txtFirstName.Text.ToString(), 
                txtMiddleName.Text.ToString(), 
                txtLastName.Text.ToString(), 
                txtEmailAddress.Text.ToString(), 
                txtPhone.Text.ToString(), 
                txtAddressLine.Text.ToString(), 
                txtCity.Text.ToString(), 
                txtStateProvince.Text.ToString(), 
                txtPostalCode.Text.ToString()
                );

            Response.Redirect(Request.RawUrl);
    
        }

    }

}