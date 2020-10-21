using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class LinkedList
    {
        internal Node top;
        public LinkedList()
        { this.top = null; }
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                this.top = node;
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is added into Linked list", node.data);
        }
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                this.top = node;
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is appended into Linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Console.WriteLine("Elements inside Linked List");
            while (temp != null)
            {
                Console.Write("->"+temp.data );
                temp = temp.next;
            }
        }
        internal Node InsertAtGivenPos(int pos, int data)
        {
            if (pos < 1)
                Console.WriteLine("Invalid position");
            if (pos == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.top;
                top = newNode;
            }
            else
            {
                while (pos-- != 0)
                {
                    if (pos == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.top.next;
                        top.next = node;
                        break;
                    }
                    top = top.next;
                }
                if (pos != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted value is: " + data);
            return top;
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Console.WriteLine("\n"+this.top.data + " is deleted from the linked list");
            this.top = this.top.next;
        }
        internal void PopLast()
        {
            //Node temp = this.top;
            if (this.top == null || this.top.next==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node NewNode = this.top;
            while(NewNode.next.next!=null)
            {
                Console.WriteLine("\n"+"Deleted element: " + NewNode.next.next.data);
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        internal bool Search(int value)
        {
            while(this.top !=null)
            {
                if (this.top.data == value)
                    return true;
                this.top = this.top.next;
            }
            return false ;
        }
        internal Node SearchAndInsert(int value,int data)
        {
            Node head = top;
            while (this.top != null)
            {
                if (head.data == value)
                {
                    Node node = new Node(data);
                    node.next = head.next;
                    head.next = node;
                    return node;
                }
                head = head.next;
            }
            return null;
        }
    }
}
