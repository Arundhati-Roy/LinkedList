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

            /*//UC7
            list.Append(54);
            list.Append(23);
            list.Display();
            Console.WriteLine("\nElement to be searched: ");
            int r = Convert.ToInt32(Console.ReadLine());
            if (list.Search(r))
                Console.WriteLine("\nElement found");
            else
                Console.WriteLine("Element not in Linked List");
*/
            //UC8
            list.Append(54);
            list.Append(23);
            list.Display();
            Console.WriteLine("\nElement to be searched: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement to be inserted: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (list.SearchAndInsert(s,i)!=null)
                list.Display();
            else
                Console.WriteLine("Element not in Linked List");
        }
    }
}
