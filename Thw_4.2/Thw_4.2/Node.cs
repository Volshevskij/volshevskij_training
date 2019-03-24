using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_4._2
{
    class Node<T>
        where T:IComparable
    {
        public  T Value { get; set; }

        private Node<T> NextNode { get;  set; }

        public int Index { get; set; }

        public Node(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException();
            }

            Value = value;
            NextNode = null;
        }

        public Node():this(default(T))
        {

        }

        public void SetNextNode(Node<T> node)
        {
            NextNode = node;
        }

        public Node<T> GetNextNode()
        {
            return NextNode;
        }

        public Node<T> GetLastNode()
        {
            Node<T> tmp = GetNextNode();

            while(tmp.GetNextNode() != null)
            {
                tmp = tmp.GetNextNode();
            }

            return tmp;
        }

        public Node<T> FindNodeByValue(T value)
        {
            Node<T> tmp = this;

            while (tmp.Value.CompareTo(Value) != 0)
            {
                tmp = tmp.GetNextNode();

                if(tmp == null)
                {
                    return null;
                }
            }

            return tmp;
        }

        public Node<T> FindNodeByIndex(int i)
        {
            Node<T> tmp = this;

            while (tmp.Index != i)
            {
                tmp = tmp.GetNextNode();

                if (tmp == null)
                {
                    return null;
                }
            }

            return tmp;
        }

        public void ReboundNode(int i, Node<T> node)
        {
            Node<T> tmp = this;

            while (true)
            {
                if(tmp.GetNextNode().Index == i)
                {
                    Node<T> old = tmp.GetNextNode();
                    tmp.SetNextNode(node);
                    tmp.GetNextNode().Index = old.Index;
                    tmp.GetNextNode().SetNextNode(old.GetNextNode());
                }

            }
        }
    }
}
