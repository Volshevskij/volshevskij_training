using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество коэффициентов 1го мнгогочлена");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество коэффициентов 2го мнгогочлена");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (n1 > n2)
            {
                count = n1;
            }
            else
            {
                count = n2;
            }

            double[] polinom1 = new double[count];
            double[] polinom2 = new double[count];

            Console.WriteLine("Введите коэффициенты 1го мнгогочлена в обратном порядке");
            for (int i = 0; i < n1;i++)
            {
                polinom1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите коэффициенты 2го мнгогочлена в обратном порядке");
            for (int i = 0; i < n2; i++)
            {
                polinom2[i] = Convert.ToInt32(Console.ReadLine());
            }

            double[] result = CalculatePolinom(polinom1, polinom2);

            Console.WriteLine("Ответ:");
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
       public static double[] CalculatePolinom(double[] polinom1, double[] polinom2)
        {
            int count = 0;
            if(polinom1.Length > polinom2.Length)
            {
                count = polinom1.Length;
            }
            else
            {
                count = polinom2.Length;
            }

            double[] result = new double[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = polinom1[i] + polinom2[i];
            }
            return result;
        }
    }
}
