using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo!");
            LinkedList list = new LinkedList();

            //UC1
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            Console.WriteLine("\n");

            //UC3
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            //Console.WriteLine("After insertion " + list.InsertAtGivenPos(2, 30));
            //list.Display();

        }
    }
}
