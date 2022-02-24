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
    }
}
