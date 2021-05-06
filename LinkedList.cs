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
        internal Node Insert(int position,int data)
        {
            if(position<1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position Out Of range");
            }
            return head;
        }
        //uc5
        internal Node Remove_First_Element()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node Remove_Last_Element()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head.next;
            }
            Node newNode = head.next;
            while (newNode.next.next!=null)
            {
                newNode = newNode.next;

            }
            newNode.next = null;
            return head;
        }
    }
}
