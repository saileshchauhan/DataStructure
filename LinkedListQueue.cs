using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedListQueue
    {
        private Node head=null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Element added to Queue is" + node.data);
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Element added in Queue"+temp.data);
                    temp = temp.next;
                }
            }
        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty ");
                return;
            }
            Console.WriteLine("{0} is Dequeued ",head.data);
            head = head.next;
        }
    }
}
