/*  
*  Copyright © 2012 Matthew David Elgert - mdelgert@yahoo.com
*  
*  http://www.codeplex.com/site/users/view/mdelgert
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
*  Project URL: https://mstestproject.codeplex.com/                          
*  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public static class Contacts
    {

        public static int Create(string firstName, string middleName, string lastName, string emailAddress, string phone, string addressLine, string city, string stateProvince, string postalCode)
        {
            int contactID = 0;

            try
            {
                DAL.Contact r = new DAL.Contact
                {
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    EmailAddress = emailAddress,
                    Phone = phone,
                    AddressLine = addressLine,
                    City = city,
                    StateProvince = stateProvince,
                    PostalCode = postalCode
                };

                Utils.DbContext.AddToContacts(r);
                Utils.DbContext.SaveChanges();
                contactID = r.ContactID;
            }
            catch (Exception ex)
            {
                ElmahExtension.LogToElmah(ex);
            }

            return contactID;

        }

        public static bool AddRadomContact()
        {
            bool completed = false;

            try
            {
                using (EntitiesContext context = new EntitiesContext())
                {
                    var r = Utils.DbContext.ContactsTestDatas.OrderBy(q => Guid.NewGuid()).FirstOrDefault();
                    Create(r.FirstName, r.MiddleName, r.LastName, r.EmailAddress, r.Phone, r.AddressLine, r.City, r.StateProvince, r.PostalCode);
                }

                completed = true;
            }
            catch (Exception ex)
            {
                ElmahExtension.LogToElmah(ex);
                completed = false;
            }

            return completed;
        }

        public static bool Delete(int contactID)
        {
            bool completed = false;

            try
            {
                DAL.Contact r = Utils.DbContext.Contacts.Where(p => p.ContactID == contactID).FirstOrDefault();
                Utils.DbContext.DeleteObject(r);
                Utils.DbContext.SaveChanges();
                completed = true;
            }
            catch (Exception ex)
            {
                ElmahExtension.LogToElmah(ex);
                completed = false;
            }

            return completed;

        }

    }

}
