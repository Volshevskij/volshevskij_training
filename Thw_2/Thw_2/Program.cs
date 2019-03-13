using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDiferrenseFinder ar = new ArrayDiferrenseFinder();

            int[] a = { 1, -2, -2, 4, 5 };
            int[] b = { 1, 4, 4, 16, 25 };

            Console.WriteLine(ar.CheckForSquareEquails(a, b));

        }
    }
}
