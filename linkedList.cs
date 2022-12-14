using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class linkedList
    {
        public Node head;
        int position = 0;

        public void Add(int data)
        {
            Node objNode = new Node(data);
            if (this.head == null)
            {
                this.head = objNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objNode;
            }
            Console.WriteLine($"\n{objNode.data} inserted into Linked List");
        }

        public void InsertBetween(int new_data)
        {
            position = 3;
            Node objnew_Node = new Node(new_data);
            objnew_Node.data = new_data;
            objnew_Node.next = null;

            if (position < 1)
            {
                Console.Write("\nPosition should be >= 1");
            }
            else if (position == 1)
            {
                objnew_Node.next = this.head;
                this.head = objnew_Node;
            }
            else
            {
                Node temp = new Node(new_data);
                temp = this.head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    objnew_Node.next = temp.next;
                    temp.next = objnew_Node;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
            Console.WriteLine($"\n{objnew_Node.data} inserted at position {position}");
        }

        public void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
            this.head = this.head.next;
            Console.WriteLine("\nRemoved first node");
        }

        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("\nLinked List Empty");
                return;
            }
            if (head.next == null)
            {
                Console.WriteLine("\nLinked List contains only 1 element");
                return;
            }
            Node objNew_Node = head;
            while (objNew_Node.next.next != null)
            {
                objNew_Node = objNew_Node.next;
            }
            objNew_Node.next = null;
            Console.WriteLine("\nRemoved Last Node");
        }

        public void RemoveAtPosition(int position)
        {
            if (position < 1)
            {
                Console.Write("\nPosition should be >= 1");
            }
            else if (position == 1 && head != null)
            {
                Node nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
            }
            else
            {
                Node temp = new Node(position);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null");
                }
            }
        }

        public void sortList()
        {
            Node current = head;
            Node index = null;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data > index.data)
                        {
                            int temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }

        public Node Search(int value)
        {
            position = 1;
            Node headValue = this.head;
            while (headValue != null)
            {
                if (headValue.data == value)
                {
                    Console.WriteLine($"\nInput {value} is at position {position}");
                    return headValue;
                }
                position++;
                headValue = headValue.next;
            }
            return null;
        }

        public void Display()
        {
            int size = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is empty");
                return;
            }
            Console.Write("\nLinked List => ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nSize of Linked List is: " + size);
        }
    }
}
