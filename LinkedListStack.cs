using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
public class LinkedListStack
    {   
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                 node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack ",+value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} The top element of Stack"+this.top.data);
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Cannot perform Pop/Delete");
            }
            Console.WriteLine("Value Popped is "+this.top.data);
            Node temp;
            temp = this.top.next;
            this.top = temp;
        }
        internal void IsEmpty() 
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
            
        }


    }
}
