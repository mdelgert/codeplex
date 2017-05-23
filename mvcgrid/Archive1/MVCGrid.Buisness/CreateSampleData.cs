using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MVCGrid.DAL;


namespace MVCGrid.Buisness
{

    public static class CreateSampleData
    {
        public static void Go()
        {
            Content c = new Content();
            c.TruncateTable();
            c.Create("TEST1", "TEST");
            c.Create("TEST2", "TEST");
            c.Create("TEST3", "TEST");
            c.Create("TEST4", "TEST");
            c.Create("TEST5", "TEST");
            c.Create("TEST6", "TEST");
            c.Create("TEST7", "TEST");
            c.Create("TEST8", "TEST");
            c.Create("TEST9", "TEST");
            c.Create("TEST10", "TEST");
            c.Create("TEST11", "TEST");
        }

    }

}
