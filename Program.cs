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
            //Creating Node of 70.
            linkListMethods.InsertElementsInLinkedList(70);
            //Adding elements to the node of 70.
            linkListMethods.AddingElementsToNode(30);
            linkListMethods.AddingElementsToNode(56);
            //Verifying if elements are added or not.
            linkListMethods.DisplayLinkedList();
        }
    }
}
