using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            libLinkedList.ILinkedList linkedList = new libLinkedList.LinkedList();
            linkedList.Add("Hallo");
            linkedList.Add("Hörnchen");
            linkedList.Add("Test");
            linkedList.Add("Hier");
        }
    }
}
