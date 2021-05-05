﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data) 
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linkedList ",node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp = temp.next;
                }
            }

        }

    }
}