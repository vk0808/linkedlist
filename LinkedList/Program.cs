using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            SingleLinkedList singleLL = new SingleLinkedList();

            singleLL.AddFirst(70);
            singleLL.Display();
            Console.WriteLine("\n");

            singleLL.AddFirst(30);
            singleLL.Display();
            Console.WriteLine("\n");

            singleLL.AddFirst(56);
            singleLL.Display();
            Console.WriteLine("\n");

        }
    }
}
