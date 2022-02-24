using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Problem_Statements
{
    internal class LinkListMethods<T>
    {

        public Node<T> head;
        //Deleting a given node from the list
        public void DeletingGivenNode(T deletingNode)
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node<T> temp = head;
                Node<T> prev = head;
                while (temp != null)
                {
                    if (temp.data.Equals(deletingNode))
                    {
                        break;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = temp.next;
            }
        }
        //For getting size of linked list !
        public void SizeOfLinkedList()
        {
            int size = 0;
            if (head == null)
            {
                Console.WriteLine("Linked listis empty.");
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    size++;
                    temp = temp.next;
                }
                Console.WriteLine("The size of the linked list is " + size);
            }
        }

        //Inserting Node after a given node.
        public void InsertNodeAfterDefinedNode(T data, T definedNode)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node<T> temp = head;
                Node<T> prev = head;
                while (temp != null)
                {
                    if (temp.data.Equals(definedNode))
                    {
                        newNode.next = temp.next;
                        break;
                    }
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        //Searching the Node & Finding its position.
        public void SearchingNode(T data)
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node<T> temp = head;
                int positionOfSearchedNode = 0;
                while (temp != null)
                {
                    positionOfSearchedNode++;
                    if (temp.data.Equals(data))
                    {
                        Console.WriteLine($"Your {data} node is found at {positionOfSearchedNode} position.");
                        break;
                    }
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine($"Specified {data} node is not present in the linked list.");
                }
            }

        }
        //For removing last node in linkedlist.
        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node<T> temp = head;
                Node<T> prev = head;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = null;
            }
        }
        //For deleting 1st Element in linked list.
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                head = head.next;
            }
        }

        //For inserting elements at last in LinkedList.
        public void InsertElementsInLinkedList(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine($"{newNode.data} is being added.");
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine($"{newNode.data} is being added.");
            }
        }
        //For displaying elements of linked list on Console.
        public void DisplayLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    Console.WriteLine($"{temp.data}");
                    temp = temp.next;
                }
                Console.WriteLine($"{temp.data}");
            }
        }
        //Adding between two nodes.Works for only three elements in linked list.
        public void AddingElementBetweenTwoNodes(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            temp = temp.next;
            newNode.next = temp;
            head.next = newNode;
        }
    }
}
