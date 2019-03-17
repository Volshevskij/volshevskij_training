using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_3._2
{
    abstract class  AbstractFlower:IFlower
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
