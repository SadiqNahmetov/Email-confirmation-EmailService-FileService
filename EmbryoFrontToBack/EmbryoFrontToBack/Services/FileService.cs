using EmbryoFrontToBack.Services.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmbryoFrontToBack.Services
{
    public class FileService : IFileService
    {
        //"wwwroot/assets/templates/verify.html"
        public string ReadFile(string path, string template)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                template = reader.ReadToEnd();
            }

            return template;
        }
    }
}
