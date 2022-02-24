using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Problem_Statements
{
    internal class SortedLinkedListClass <T>
    {
        public Node <T> head = null;
        //For INserting element at last position.
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
        //For Sorting a list in array in ascending order.
        public void SortList()
        {
            Node<T> current = head;
            T index;

            if (head == null)
            {
                return;
            }
            else
            {
                while(current != null)//For traversing through the list
                {
                    Node<T> temp = current;
                    while (temp != null)//For traversing this list.
                    {
                        if(Comparer<T>.Default.Compare(current.data,temp.data)> 0)
                        {
                            index = current.data;
                            current.data = temp.data;
                            temp.data = index;

                        }
                        temp = temp.next;
                    }
                    current = current.next;
                }
            }
        }
        //For displaying the elements in list.
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
    }
}
