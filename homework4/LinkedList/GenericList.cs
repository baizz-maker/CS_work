using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() { head = null;tail = null; }
        public Node<T> Head() { return head; }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                tail = n;
                head = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }

        }

        public void ForEach ( Action<T> action)
        {
            Node<T> temp=this.head;
            
            while (temp != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }  
        }
    }
}
