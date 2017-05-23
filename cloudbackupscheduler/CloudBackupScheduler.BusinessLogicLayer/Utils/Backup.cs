using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenZip;

namespace CloudBackupScheduler.BusinessLogicLayer.Utils
{
    public static class Backup
    {

        public static void FolderArchive(string _sourceFolder, string _destination_folder)
        {
            //http://sevenzipsharp.codeplex.com/discussions/224920
            var tmp = new SevenZipCompressor();
            tmp.ScanOnlyWritable = true;
            tmp.CompressDirectory(_sourceFolder, _destination_folder);

        }

    }

}
