using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Type number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] res = GetIntArray(a);
            for (int i = 1; i <= n; i++)
            {  
                int[] worker = ArrayMult(res, i);
                res = worker;
            }

            string s = "";
            bool trigger = false;
            for(int i = 0; i < res.Length; i++)
            {
                if(res[i] == 0 && trigger == false)
                {
                    continue;
                }
                else
                {
                    trigger = true;                    
                }
                if(trigger == true)
                {
                    s += res[i];
                }
            }
            Console.WriteLine(s);
        }

        static int[] GetIntArray(int n)
        {
            string nConv = Convert.ToString(n);

            int[] Conv = new int[nConv.Length];

            for (int i = 0; i < Conv.Length; i++)
            {
                Conv[i] = (int)Char.GetNumericValue(nConv[i]);
            }

            return Conv;
        }

        static int[] ArrayMult(int[] arr, int n)
        {
            int tmp = 0;
            int[] helper = new int[100000];
            int heLen = helper.Length - 1;
            for(int i = arr.Length -1; i >=0; i--)
            {
                helper[heLen] = arr[i];
                heLen--;
            }

            for (int i = helper.Length - 1; i >= 0; i--)
            {
                int mult = (helper[i] * n) + tmp;
                tmp = mult / 10;
                helper[i] = mult % 10;
            }

            return helper;
        }
    }
}

