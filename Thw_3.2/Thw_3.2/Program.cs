using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose r = new Rose();
            Violet v = new Violet();
            Bluebell b = new Bluebell();

            Bouquet bouquet = new Bouquet();

            bouquet.AddFlower(r);
            bouquet.AddFlower(v);
            bouquet.AddFlower(b);

            Console.WriteLine("Bouquet price: " + bouquet.Price);
        }
    }
}
