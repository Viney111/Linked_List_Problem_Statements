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
            //Insert Node after a defined Node !
            linkListMethods.InsertNodeAfterDefinedNode(40,30);
            //Verifying if UC Purpose id filled or not !
            linkListMethods.DisplayLinkedList();
        }
    }
}
