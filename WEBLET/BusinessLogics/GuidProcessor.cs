using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.BusinessLogics
{
    public class GuidProcessor
    {
        public static string SaveFile(string rootPath,string fileName,IFormFile file)
        {
            string uniquefilename = Guid.NewGuid().ToString() + "_" + fileName;
            string filepath = Path.Combine(rootPath, uniquefilename);
                file.CopyTo(new FileStream(filepath, FileMode.Create));
            return uniquefilename;
        }
    }
}
