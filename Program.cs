using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            
            list.Insert(2, 39);
            //list.Remove_First_Element();
            //list.Remove_Last_Element();
            //list.Search_Input_Value(30);
            //UC 8
            list.Insert_40_After_30(30, 40);
            //UC 9
            list.Delete_40_From_LinkedList(40);


            
            //LinkedListStack stack = new LinkedListStack();
            ////uc1
            //stack.Push(70);
            //stack.Push(56);
            //stack.Push(30);
            ////uc2
            //stack.pop();

            //LinkedListQueue queue = new LinkedListQueue();
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(70);
            //queue.Display();
            //Console.WriteLine("===============");
            //queue.Dequeue();






        }
    }
}
