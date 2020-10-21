using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo!");
            LinkedList list = new LinkedList();

            //UC10
            list.sortedInsert(23);
            list.sortedInsert(87);
            list.sortedInsert(2);
            list.sortedInsert(76);
            list.sortedInsert(5);
            list.sortedInsert(0);
            list.Display();
        }
    }
}
