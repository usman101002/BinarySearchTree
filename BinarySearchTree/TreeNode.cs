using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class TreeNode<T> where T : IComparable, IComparable<T>
    {
        public T Val;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T data)
        {
            this.Val = data;
            this.Left = null;
            this.Right = null;
        }

        public  void AddNode(T data)
        {
            if (this.Val.CompareTo(data) < 0)
            {
                if (this.Right == null)
                {
                    this.Right = new TreeNode<T>(data);
                }
                else
                {
                    this.Right.AddNode(data);
                }
            }
            else
            {
                if (this.Left == null)
                {
                    this.Left = new TreeNode<T>(data);
                }
                else
                {
                    this.Left.AddNode(data);
                }
            }
        }

        public override string ToString()
        {
            return this.Val.ToString();
        }

    }
}
