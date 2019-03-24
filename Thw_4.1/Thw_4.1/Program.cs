using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_4._1
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                WordFrequencyCounter r = new WordFrequencyCounter("Simple simple text");

                foreach (string s in r.GetAnswer())
                {
                    Console.WriteLine(s);
                }
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("String not found");
            }
        }
    }
}
