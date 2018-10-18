using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_1
{
    class MyList<E>
    {
        private Cell<E> _root;
        private int _count;
        private int _currentCount;

        public MyList()
        {
            _count = 2;
            _root = null;
            _currentCount = 0;
        }

        public MyList(int count):this()
        {
            _count = count;
            if(_count <= 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void AddRootCell (ref Cell<E> cell)
        {
            if(_currentCount > _count)
            {
                throw new AddingExceptionHandler();
            }

            cell.SetNextCell(_root);
            _root = cell;
            _currentCount++;
        }

        public void AddNextCell(ref Cell<E> cell1, ref Cell<E> cell2)
        {
            if (cell2 == _root)
            {
                RemoveNextCell(_root);
                AddRootCell(ref cell1);
            }

            if (_currentCount > _count)
            {
                 throw new AddingExceptionHandler();
            }

            else
            {
                Cell<E> tmp = cell1.GetNextCell();
                cell1.SetNextCell(cell2);
                cell2.SetNextCell(tmp);
                _currentCount++;
            }
        }

        public E[] GetCellValues()
        {
            Cell<E> tmp = _root;
            E[] res = new  E [_currentCount];
            int i = 0;
            while(true)
            {
                if (tmp == null)
                {
                    break;
                }
                if(i == _currentCount)
                {
                    break;
                }
                res[i] = tmp.GetValue();
                tmp = tmp.GetNextCell();
                i++;
            }
            return res;
        }

        public void RemoveNextCell(Cell<E> cell)
        {
            Cell<E> tmp = new Cell<E>();
            tmp = cell.GetNextCell();

            if (tmp != null)
            {
                cell.SetNextCell(tmp.GetNextCell());
            }
            else
            {
                throw new ArgumentNullException();
            }
            _currentCount--;
        }

        public void RemoveRoot()
        {
            if(_root == null)
            {
                throw new ArgumentNullException();
            }

            Cell<E> tmp = _root.GetNextCell();
            _root = tmp;
            _currentCount--;
        }


    }
}
