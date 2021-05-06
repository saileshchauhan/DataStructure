using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
          //list.Add(30);
            list.Add(70);
          //list.Display();
            list.Insert(2, 30);
            list.Display();
            list.Remove_First_Element();
            list.Remove_Last_Element();
            list.Search_Input_Value(30);



        }
    }
}
