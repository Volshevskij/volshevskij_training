using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\goncharov_ivan-obyknovennaja_istorija.txt";
            string path2 = @"C:\Users\User\Desktop\pack.txt";
            string path3 = @"C:\Users\User\Desktop\unpack.txt";

            Archivator re = new Archivator();

            re.GetTextFromFile(path);

            re.CreateAlphabet();

            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(re.Archivate());
            }

            using (StreamWriter sw = new StreamWriter(path3, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(re.UnArchivate(re.Archivate()));
            }

            Console.WriteLine("Done");
        }
    }
}
