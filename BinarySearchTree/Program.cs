using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>();
            bst.AddData(3);
            bst.AddData(5);
            bst.AddData(7);
            bst.AddData(2);

            var preorder = bst.Preorder();
            
            foreach (var item in preorder)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            var inorder = bst.Inorder();

            foreach (var item in inorder)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            var postorder = bst.Postorder();
            foreach (var item in postorder)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
