using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PhotoServiceHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(WCFServiceLib.PhotoService)))
            {
                host.Open();

                Console.WriteLine("Host online............");
                Console.ReadLine();
            }
        }
    }
}
