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
            SortedLinkedListClass<int> list = new SortedLinkedListClass<int>();
            list.InsertElementsInLinkedList(56);
            list.InsertElementsInLinkedList(30);
            list.InsertElementsInLinkedList(40);
            list.InsertElementsInLinkedList(70);
            //Calling SortList method...
            list.SortList();
            list.DisplayLinkedList();
        }
    }
}
