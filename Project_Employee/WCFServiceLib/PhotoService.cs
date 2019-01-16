using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceLib
{
    public class PhotoService : IPhotoService
    {
        public byte[] GetPhoto(string path)
        {
            Random r = new Random();
            r.Next(1,4);
            string fullPath = path + r + ".jpg";

                //var fileName = r;

                //FileStream fs = new FileStream(path, FileMode.Open);

                //byte[] buffer = new byte[fs.Length];
                //fs.Read(buffer, 0, (int)fs.Length);

                //fs.Close();
            
            return File.ReadAllBytes(fullPath);
        }
    }
}
