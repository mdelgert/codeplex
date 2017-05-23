using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip;
using System.IO;
using System.Security.AccessControl;


namespace BLL
{
    public static class SevenZipUtil
    {

        public static void CompressDirectory(string Directory, string AchiveFile, string Password = null)
        {
            var tmp = new SevenZipCompressor();   
            tmp.ZipEncryptionMethod = ZipEncryptionMethod.Aes256;
            tmp.CompressDirectory(Directory, AchiveFile, Password);
        }

    }

}
