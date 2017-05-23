using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCGrid.DAL;

//CRUD operations
namespace MVCGrid.Buisness
{
    public class Content
    {
        EntitiesContext MVCGridDB = new EntitiesContext();

        public void Create(string _PageName, string _ContentText)
        {
            DAL.Content r = new DAL.Content
            {
                PageName = _PageName,
                ContentText = _ContentText,
                CreateDate = DateTime.Now
            };

            MVCGridDB.AddToContents(r);
            MVCGridDB.SaveChanges();
        }
        
        public void TruncateTable()
        {
            MVCGridDB.ExecuteStoreCommand("TRUNCATE TABLE dbo.Content");
            //MVCGridDB.ExecuteStoreCommand("TRUNCATE TABLE dbo.Content");
        }

    }

}
