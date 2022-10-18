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
            libLinkedList.ILinkedList<string> linkedList = new libLinkedList.LinkedList<string>();
            linkedList.Add("Hallo");
            linkedList.Add("Hörnchen");
            linkedList.Add("Test");
            linkedList.Add("Hier");
            linkedList.Add("Hallo1");
            linkedList.Add("Hörnchen1");
            linkedList.Add("Test1");
            linkedList.Add("Hier1");

 
            linkedList.Remove("Hörnchen");
            Console.WriteLine(linkedList.Contains("Hörnchen"));   
            Console.WriteLine(linkedList.Contains("Hallo"));   
            Console.WriteLine(linkedList.Contains("Test"));   
            Console.WriteLine(linkedList.Contains("Hier"));   
            Console.WriteLine(linkedList.Contains("Hallo1"));   
            Console.WriteLine(linkedList.Contains("Hörnchen1"));   
            Console.WriteLine(linkedList.Contains("Test1"));
            Console.WriteLine(linkedList.Contains("Hier1"));

            Console.WriteLine(linkedList.Count().ToString());
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press Enter to Close");

            Console.ReadLine();
        }
    }
}
