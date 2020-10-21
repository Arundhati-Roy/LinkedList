using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo!");
            LinkedList list = new LinkedList();

            
            //UC4
            list.Add(56);
            list.Add(89);
            list.Add(43);
            list.Display();
            Console.WriteLine("\nAfter insertion " );
            list.InsertAtGivenPos(2, 30);
            list.Display();
        }
    }
}
