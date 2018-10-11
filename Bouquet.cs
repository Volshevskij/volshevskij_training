using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TK_3
{
    class Bouquet
    {
        int _cost;
        List<Flowers> _bouquet;

        Bouquet(List<Flowers> bouquet)
        {
            _bouquet = bouquet;
        }

        Bouquet()
        {

        }

        public void AddFlower(Flowers f)
        {
            _bouquet.Add(f);
            _cost += f.GetCost();
        }

        public int GetBouquetCost()
        {
            return _cost;
        }

        public List<Flowers> GetBouquet()
        {
            return _bouquet;
        }

    }
}
