using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SingleLinkedList
    {
        internal Node head;

        // Method to add at first position
        internal void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine($"{node.data} is added to linked list");
        }

        // Method to display
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }


        }
    }
}