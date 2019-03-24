using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_4._2
{
    class MyList<T>
        where T: IComparable
    {
        Node<T> FirstNode { get; set; }

        public int Count { get; private set; }

        public Node<T> this[int index]
        {
            get
            {
               return FirstNode.FindNodeByIndex(index);
            }
            set
            {
                Node<T> tmp = FirstNode.FindNodeByIndex(index);
                tmp  = value;
            }
        }
            
        public MyList(T value)
        {
            Count = 0;

            FirstNode = new Node<T>();
            FirstNode.Index = Count;
            FirstNode.Value = value;
        }

        public MyList():this(default(T))
        {

        }

        public void Remove(int i)
        {
            Count--;
            Node<T> tmp = FirstNode;

            while (true)
            {
                if (tmp.GetNextNode().Index == i)
                {
                    Node<T> old = tmp.GetNextNode();
                    tmp.SetNextNode(old.GetNextNode());
                    break;
                }
                tmp = tmp.GetNextNode();
            }
        }

        public void RemoveByValue(T i)
        {
            Count--;
            Node<T> tmp = FirstNode;

            while (true)
            {
                if (tmp.Value.CompareTo(i) == 1)
                {
                    Node<T> old = tmp.GetNextNode();
                    tmp.SetNextNode(old.GetNextNode());
                    break;
                }

                tmp = tmp.GetNextNode();
            }
        }

        public T[] ToArray()
        {
            T[] arr = new T[Count + 1];
            Node <T> tmp = FirstNode;

            for(int i = 0; i <= Count; i++)
            {
                if (tmp != null)
                {
                    arr[i] = tmp.Value;
                    tmp = tmp.GetNextNode();
                }
            }

            return arr;
        }

        public void Add(T value)
        {
            Count++;

            Node<T> newOne = new Node<T>(value);
            newOne.Index = Count;

            Node<T> tmp = FirstNode;

            for (int i = 0; i < Count; i++)
            {
                var old = tmp;
                tmp = tmp.GetNextNode();

                if(tmp == null)
                {
                    old.SetNextNode(newOne);
                    break;
                }

                if (tmp.Value.CompareTo(newOne.Value) == 1)
                {
                    old.SetNextNode(newOne);
                    newOne.SetNextNode(tmp);
                    break;
                }

                if (tmp.GetNextNode() == null)
                {
                    tmp.SetNextNode(newOne);
                    break;
                }
            }
        }
    }
}
