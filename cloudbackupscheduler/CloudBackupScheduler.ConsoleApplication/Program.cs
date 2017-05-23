using System;
using System.Resources;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudBackupScheduler.BusinessLogicLayer.Utils;

namespace CloudBackupScheduler.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CloudBackupScheduler.ConsoleApplication.Properties.Resources.ResourceManager.GetString("License"));
            Console.WriteLine("BEGIN:");
            Backup.FolderArchive(@"C:\SampleCode\Visual Studio 2012\Tile-Update-every-minute-68dbbbff", @"C:\Temp\1arch.7z");
            Console.WriteLine("END:");
            Console.ReadKey();
        }
    }
}
