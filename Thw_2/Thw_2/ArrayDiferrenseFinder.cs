using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_2
{
    class ArrayDiferrenseFinder
    {
        public bool CheckForSquareEquails(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length == 0 || b.Length == 0)
            {
                return false;
            }
            for(int i = 0; i < a.Length; i++)
            {
                int numCounter = 0;
                int squareCounter = 0;
                int currentNumber = a[i];
                int currentNumberSquare = Convert.ToInt32(Math.Pow(currentNumber, 2));

                foreach(int c in a)
                {
                    if(c == currentNumber)
                    {
                        numCounter++;
                    }
                }

                foreach(int c in b)
                {
                    if(c == currentNumberSquare)
                    {
                        squareCounter++;
                    }
                }

                if(numCounter != squareCounter)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
