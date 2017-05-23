using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Helpdesk
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
            Application.Run(new Form1());
        }
    }
}


// Adding drive mappings
//http://stackoverflow.com/questions/1898195/mapped-network-drives-cannot-be-listed-in-c-sharp
// Default Printer Name
//http://stackoverflow.com/questions/680788/how-to-get-the-default-printer-name-with-network-path