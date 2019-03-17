using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._2
{
    class Bouquet
    {
        List<AbstractFlower> bouquet = new List<AbstractFlower>();
        public int Price { get; private set; }

        public void AddFlower(AbstractFlower f)
        {
            bouquet.Add(f);
            Price += f.Price;
        }
    }
}
