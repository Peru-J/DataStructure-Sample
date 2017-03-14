using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructure.DelegateExample;

namespace DataStructure
{
    class Program
    {

        public delegate int Addnumber(int a, int b);
        static void Main(string[] args)
        {
            #region LinkedList
            /*Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.printAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.printAllNodes();

            Console.ReadLine();*/
            #endregion

            #region ReverseString
            //ReverseString reverse = new ReverseString();
            //Console.WriteLine(reverse.ReverseaString("Peru").ToString());
            //Console.ReadLine();
            #endregion

            #region Delegates
            /*Addnumber num = new Addnumber(AddNumbers);
            Console.WriteLine(num(12, 10));
            Console.ReadLine();*/

            #endregion

            #region BinaryTree

            /* BinaryTreeImp btObj = new BinaryTreeImp();
             BinaryNode iniRoot = btObj.addNode(5);


             btObj.insertNode(btObj.root, iniRoot);
             btObj.insertNode(btObj.root, btObj.addNode(6));
             btObj.insertNode(btObj.root, btObj.addNode(10));
             btObj.insertNode(btObj.root, btObj.addNode(2));
             btObj.insertNode(btObj.root, btObj.addNode(3));
             btObj.displayTree(btObj.root);
             btObj.FindMax(btObj.root);
             System.Console.WriteLine("The sum of nodes are " + BinaryTreeImp.count);
             Console.ReadLine();*/


            #endregion

            #region  Split string

            /* string s = "Am12 i12 good";
             char[] cc = new char[] { '1', '2' };
             string[] ss = s.Split(cc);

             SplitString split = new SplitString();

             SplitString.split(s,new char[] { '1', '2' });*/

            #endregion

            #region StringToNumber
            // StringToNumber.convertToInt("23232");
            //StringToNumber.convertToFloat("232.32");

            // StringToNumber.ConvertToUpperCase("PeRu");
            #endregion

            #region stringOperations
            // StringOperation.ReverseWord();

            // StringOperation.ReverseWordWithoutReversingIndividual();

            #endregion

            #region Sorting Algoritham
            // QuickSortAlgoritham.QuickSort();
            // SelectionSort.selectionSort();
            MergeSort.ImplementMergerSort();
            #endregion

            #region IndexOf finding substring in string
            // IndexOf.IndexOfString();
            #endregion

        }
    }
}
