using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Problem_Statements
{
    internal class LinkListMethods
    {

        public Node head;
        //For removing last node in linkedlist.
        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node temp = head;
                Node prev = head;
                while(temp.next != null)
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
        public void InsertElementsInLinkedList(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine($"{newNode.data} is being added.");
            }
            else
            {
                Node temp = head;
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
                Node temp = head;
                while(temp.next != null)
                {
                    Console.WriteLine($"{temp.data}");
                    temp =temp.next;
                }
                Console.WriteLine($"{temp.data}");
            }
        }
        //Adding between two nodes.Works for only three elements in linked list.
        public void AddingElementBetweenTwoNodes(int data)
        {
            Node newNode = new Node(data);
            Node temp = head;   
            temp = temp.next;
            newNode.next = temp;
            head.next = newNode;
        }
    }
}
