using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            libLinkedList.ILinkedList<string> linkedList = new libLinkedList.LinkedList<string>();
            string[] strings = new string[] { "String1", "String2", "String3", "String4", "String5", "String6" };
            //Add 6 string
            foreach (string s in strings)
            {
                linkedList.Add(s);
            }

            foreach (string item in linkedList)
            {
                Console.WriteLine("Value:" + item);
            }
            //Check if existing:
            string str = "String1";
            Console.WriteLine("\nContains" + str + " : " + linkedList.Contains(str));
            str = "String7";
            Console.WriteLine("Contains" + str + " : " + linkedList.Contains(str));

            //Output of specific values:
            int[] index = new int[] { 1, 3, 5 };
            foreach (var i in index)
            {
                Console.WriteLine("\nValue at Index " + i + " is " + linkedList.FindbyIndex(i));
            }

            //Delete specific values and check if the value is no longer include in side the list
            str = "String3";
            linkedList.Remove(str);

            Console.WriteLine("\n New list after removing");
            foreach (string item in linkedList)
            {
                Console.WriteLine("Value:" + item);
            }

            Console.WriteLine("\nPress Enter to Close");

            Console.ReadLine();
        }
    }
}
