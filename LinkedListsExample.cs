using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankLinkedLists
{
    class LinkedListsExample
    {
        // Complete the insert function in your editor so that it creates a 
        //new Node(pass  as the Node constructor argument) and inserts it 
        //at the tail of the linked list referenced by the parameter.
        //Once the new node is added, return the reference to the  node.
         static void Main(string[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        private static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }

        private static Node insert(Node head, int data)
        {
            if (head != null)
            //Insert a new node at the end of the list   
            {
                Node nextNode = head;
                while (nextNode.next != null)
                {
                    nextNode = nextNode.next;
                }
                Node newNode = new Node(data);
                nextNode.next = newNode;
            }
            else
            //Initialize an empty list
            {
                Node node = new Node(data);
                head = node;
            }
            return head;
        }
    }
}
