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
            
            //UC9
            list.Append(54);
            list.Append(23);
            list.Display();
            Console.WriteLine("\nElement to be searched and deleted: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (list.SearchAndDelete(d) != 0)
            {
                list.Display();
                Console.WriteLine("\nSize of Linked List is: " + list.SearchAndDelete(d));
                //list.Display();
            }
            else
                Console.WriteLine("Element not in Linked List");
        }
    }
}
