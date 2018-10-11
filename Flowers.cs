using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TK_3
{
    abstract  class Flowers
    {
        private string[] _names = { "Rose", "Carnation", "Tulip", "Violet", "Chamomile" };
        string _name;
        int _cost;
        private int[] _costs = {20, 15, 10, 8, 5 };

        public Flowers()
        {
            _name = "Rose";
            _cost = 20;
        }

        public  Flowers(string name)
        {
            for(int i = 0; i < _names.Length; i++)
            {
                if(name == _names[i])
                {
                    _name = name;
                    _cost = _costs[i];
                }
            }
        }

        public string GetName()
        {
            return _name;
        }

        public int GetCost()
        {
            return _cost;
        }
    }
}
