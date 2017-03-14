using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Class Declaration for BinaryTree
    /// </summary>
    class BinaryNode
    {
        public int data;
        public BinaryNode left, right;
   //Added comment
        public BinaryNode(int data)
        {
            this.data = data;
            left = null;
            right = null;

        }
    }

    class BinaryTreeImp
    {
        public BinaryNode root;
        public static int count = 0;

        public BinaryTreeImp()
        {
            root = null;

        }
        public BinaryNode addNode(int data)
        {
            BinaryNode newNode = new BinaryNode(data);

            if (root == null)
            {
                root = newNode;

            }
            count++;
            return newNode;


        }

        public void insertNode(BinaryNode root, BinaryNode newNode)
        {
            BinaryNode temp;
            temp = root;

            if (newNode.data < temp.data)
            {
                if (temp.left == null)
                {
                    temp.left = newNode;

                }

                else
                {
                    temp = temp.left;
                    insertNode(temp, newNode);

                }
            }
            else if (newNode.data > temp.data)
            {
                if (temp.right == null)
                {
                    temp.right = newNode;

                }

                else
                {
                    temp = temp.right;
                    insertNode(temp, newNode);
                }
            }
        }


        public void displayTree(BinaryNode root)
        {
            if (root == null)
                return;

            displayTree(root.left);
            System.Console.Write(root.data + " ");
            displayTree(root.right);

        }

        public int FindMax(BinaryNode root)
        {
            int max = root.data;
            if (root.right != null)
            {
                max = Math.Max(max, FindMax(root.right));
            }
            Console.WriteLine("Maximum Value:  " + max);
            return max;
        }
    }

}
