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
            list.Append(56);
            list.Append(89);
            list.Append(43);
            list.Display();
            Console.WriteLine("\nAfter insertion " );
            list.InsertAtGivenPos(2, 30);
            list.Display();

            //UC5
            list.Pop();
            list.Display();

            //UC6
            list.PopLast();
            list.Display();
        }
    }
}
