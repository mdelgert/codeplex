// 
// Copyright © 2012 Matthew David Elgert - mdelgert@yahoo.com
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2.1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA 
// 
// Author: Matthew David Elgert - http://www.codeplex.com/site/users/view/mdelgert
// 
  
using System;
using System.Linq;
using Base.DataModel;

namespace Base.DataAccessLayer
{
    public class LogApplicationDAL
    {
        public static void Create()
        {
            //static DataClasses1DataContext context2;
            using (var context = new BaseEntities())
            {
                var newLog = new LogApplicationModel()
                {
                    Message = "TEST",
                    CreatedOn = System.DateTime.Now
                };

                context.LogApplication.Add(newLog);
                //Standard save
                //context.SaveChanges();
                context.Save();
            }
        }
    }
}