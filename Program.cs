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
            linkListMethods.InsertElementsInLinkedList(70);
            //Adding Node of 30 between 56 & 70.
            linkListMethods.AddingElementBetweenTwoNodes(30);
            //Verifying if UC Purpose id filled or not !
            linkListMethods.DisplayLinkedList();
        }
    }
}
