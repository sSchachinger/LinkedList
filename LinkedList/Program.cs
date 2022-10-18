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
            //Add 6 string
            linkedList.Add("String1");
            linkedList.Add("String2");
            linkedList.Add("String3");
            linkedList.Add("String4");
            linkedList.Add("String5");
            linkedList.Add("String6");

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

            Console.WriteLine("\nValue at Index " + index[0] + " is " + linkedList.FindbyIndex(index[0]));
            Console.WriteLine("Value at Index " + index[1] + " is " + linkedList.FindbyIndex(index[1]));
            Console.WriteLine("Value at Index " + index[2] + " is " + linkedList.FindbyIndex(index[2]));

            foreach (string item in linkedList)
            {
                Console.WriteLine("Value:" + item);
            }
            //Delete specific values and check if the value is no longer include in side the list
            str = "String3";
            linkedList.Remove(str);
            Console.WriteLine("\nContains" + "String1" + " : " + linkedList.Contains("String1"));
            Console.WriteLine("Contains" + "String2" + " : " + linkedList.Contains("String2"));
            Console.WriteLine("Contains" + "String3" + " : " + linkedList.Contains("String3"));
            Console.WriteLine("Contains" + "String4" + " : " + linkedList.Contains("String4"));
            Console.WriteLine("Contains" + "String5" + " : " + linkedList.Contains("String5"));
            Console.WriteLine("Contains" + "String6" + " : " + linkedList.Contains("String6"));

            Console.WriteLine("\nPress Enter to Close");

            Console.ReadLine();
        }
    }
}
