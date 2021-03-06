using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            SingleLinkedList singleLL = new SingleLinkedList();

            singleLL.AddLast(56);
            singleLL.Display();
            Console.WriteLine("\n");

            singleLL.AddLast(70);
            singleLL.Display();
            Console.WriteLine("\n");

            singleLL.InsertAfter(singleLL.head, 30);
            singleLL.Display();
            Console.WriteLine("\n");

            singleLL.DeleteLast();
            singleLL.Display();
            Console.WriteLine("\n");
        }
    }
}
