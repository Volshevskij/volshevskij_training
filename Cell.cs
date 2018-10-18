using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_1
{
    class Cell<T>
    {
      private  Cell<T> _nextCell;
      private  T _value;

     public   Cell()
        {
            _nextCell = null;

            _value = default(T);
        }
        public T GetValue()
        {
            return _value;
        }

        public Cell<T> GetNextCell()
        {
            return _nextCell;
        }

        public void SetValue(T v)
        {
            _value = v;
        }

        public void SetNextCell(Cell<T> c)
        {
            _nextCell = c;
        }


    }
}
