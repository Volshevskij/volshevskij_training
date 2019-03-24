using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> L = new MyList<int>();

            L.Add(4);
            L.Add(2);
            L.Add(1);

            foreach(int c in L.ToArray())
            {
                Console.WriteLine(c);
            }

            L.Remove(2);
            Console.WriteLine();

            foreach (int c in L.ToArray())
            {
                Console.WriteLine(c);
            }
        }
    }
}
