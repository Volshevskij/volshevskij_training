using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            MistakeSeeker s = new MistakeSeeker();

            string sumple = "976287093429";
          
            Console.WriteLine(s.FindSequenceError(sumple,2));


        }
    }
}
