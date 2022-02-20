using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using SautinSoft.Document;

namespace FilexWebApp.Models
{
    public class DevLib
    {
        public static string Convert(string UploadPath, string DownloadPath, string FileUniqueName, string SourceFileExt, string DestinationFileExt)
        {

            UploadPath = UploadPath + "\\" + FileUniqueName + SourceFileExt;
            DownloadPath = DownloadPath + "\\" + FileUniqueName + DestinationFileExt;

            DocumentCore dc = DocumentCore.Load(UploadPath);
            dc.Save(DownloadPath);

            return MimeMapping.GetMimeMapping(FileUniqueName + DestinationFileExt);
        }
    }
}