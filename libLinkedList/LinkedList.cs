using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLinkedList
{
    internal class Node
    {
        public object value { get; set; }

        public Node next { get; set; }

        public object _previous { get; set; }

        public Node(object val, Node nxt)
        {
            this.value = val;
            this.next = nxt;
        }
    }


    public class LinkedList : ILinkedList
    {
        private Node _head;

        public LinkedList()
        {
            _head = null;
        }
        public void Add(object item)
        {
            if (_head == null)
                _head = new Node(item, null);

            else
            {
                Node last = _head;//dient als Laufvariable; der Head-Node ist der Initialwert
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next= new Node(item, null);
            }
        }

        public bool Contains(object item)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public object FindbyIndex(int index)
        {
            throw new NotImplementedException();
        }

        public bool IsObjectAtIndex(object item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object item)
        {
            throw new NotImplementedException();
        }
    }
}
