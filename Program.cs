using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_List_Problem_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListMethods linkListMethods = new LinkListMethods();
            linkListMethods.InsertElementsInLinkedList(56);
            linkListMethods.InsertElementsInLinkedList(30);
            linkListMethods.InsertElementsInLinkedList(70);
            Console.WriteLine("First element in linked list is deleted. Resultant linked list is:- ");
            //POP method to remove first element.
            linkListMethods.Pop();
            //Verifying if UC Purpose id filled or not !
            linkListMethods.DisplayLinkedList();
        }
    }
}
