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

        // Method to append at last position
        internal void AddLast(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
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
            Console.WriteLine($"{node.data} is appended to linked list");
        }

        // Method to insert between the values
        internal void InsertAfter(Node prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("Previous node cannot be empty");
                return;
            }
            Node node = new Node(data);
            node.next = prev_node.next;
            prev_node.next = node;
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