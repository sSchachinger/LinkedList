using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace libLinkedList
{
    internal class Node<T>
    {
        public T value { get; set; }

        public Node<T> next { get; set; }

        public T _previous { get; set; }

        public Node(T val, Node<T> nxt)
        {
            this.value = val;
            this.next = nxt;
        }
    }

    public class LinkedList<T> : ILinkedList<T>, IEnumerable, IEnumerator
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int index = 0;

        public LinkedList()
        {
            _head = null;
            _tail = null;
            length = 0;
        }

        public int length { get; set; }

        public object Current
        {
            get
            {
                return FindbyIndex(index);
            }
        }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item, null);
            if (_head == null)
            {
                _head = node;
                _tail = node;
                Console.WriteLine("Head added");
            }
            else
            {
                // lineare Performance::
                //Node last = _head;//dient als Laufvariable; der Head-Node ist der Initialwert
                //while (last.next != null)
                //{
                //    last = last.next;
                //}
                //last.next = node;

                //konstante Performance:
                _tail.next = node;
                _tail = node;
                Console.WriteLine("Node added");
            }
            length++;
        }

        public bool Contains(T item)
        {
            //Variante While-Loop:
            //while (last.next != null)
            //{
            //    if (last.value.Equals(item))
            //    {
            //        return true;
            //    }
            //    last = last.next;
            //}
            //Variante for-Loop:
            for (Node<T> tmp = _head; tmp != null; tmp = tmp.next)
            {
                if (tmp.value.Equals(item))
                    return true;
            }
            return false;
        }

        public int Count()
        {
            int count = 0;
            for (Node<T> tmp = _head; tmp != null; tmp = tmp.next)
            {
                count++;
            }
            return count;
        }

        public T FindbyIndex(int index)
        {
            int count = 0;
            for (Node<T> tmp = _head; tmp != null; tmp = tmp.next)
            {
                count++;
                if (count.Equals(index))
                    return tmp.value;
            }
            return default(T);
        }
        public bool Remove(T item)
        {
            Node<T> current = _head;
            Node<T> prev = null;

            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    current = current.next;
                    if (prev != null)
                        prev.next = current;
                    length--;
                    return true;
                }
                prev = current;
                current = current.next;
            }
            return false;
        }

        public bool IsObjectAtIndex(T item, int index)
        {
            int count = 0;
            for (Node<T> tmp = _head; tmp != null; tmp = tmp.next)
            {
                if (tmp.value.Equals(item) && count.Equals(index))
                    return true;
                count++;
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            index++;
            return index <= length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
