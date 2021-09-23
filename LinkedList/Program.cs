using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LINKED LIST PROGRAM");

            LinkedList list = new LinkedList();//creating object of LL class to store the element
            list.Add(56);
            list.Display();
            list.Add(30);
            list.Display();
            list.Add(70);
            list.Display();
            Console.WriteLine("***************************************");
            list.InsertAtFirst(70);
            list.Display();
            Console.WriteLine("***************************************");
            list.InsertAtLast(56);
            list.Display();
            Console.WriteLine("***************************************");
            list.InsertAtMiddle(2, 30);
            list.Display();
            Console.WriteLine("***************************************");
            list.DeleteFirst();
            list.Display();
            Console.WriteLine("***************************************");
            list.DeleteLast();
            list.Display();
            Console.WriteLine("***************************************");
            list.searchElement(30);
        }
    }
}
