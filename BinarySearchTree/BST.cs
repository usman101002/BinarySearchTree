using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BST<T> where T : IComparable<T>, IComparable
    {
        public TreeNode<T> Root { get; private set; }
        public int Count { get; private set; }



        public BST()
        {
            this.Root = null;
        }

        public void AddData(T data)
        {
            if (this.Root == null)
            {
                this.Root = new TreeNode<T>(data);
                this.Count = 1;
            }
            else
            {
                this.Root.AddNode(data);
                this.Count++;
            }
        }

        public List<T> Preorder()
        {
            if (this.Root == null)
            {
                return new List<T>();
            }
            else
            {
                return Preorder(this.Root);
            }
        }

        private List<T> Preorder(TreeNode<T> node)
        {
            var list = new List<T>();
            if (!(node == null))
            {
                if (!(node.Left == null))
                {
                    list.AddRange(Preorder(node.Left));
                }

                list.Add(node.Val);

                if (!(node.Right == null))
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }

        public List<T> Inorder()
        {
            if (this.Root == null)
            {
                return new List<T>();
            }
            else
            {
                return Inorder(this.Root);
            }
        }

        private List<T> Inorder(TreeNode<T> node) 
        {
            var list = new List<T>();
            if (!(node == null))
            {
                list.Add(node.Val);

                if (!(node.Left == null))
                {
                    list.AddRange(Inorder(node.Left));
                }

                if (!(node.Right == null))
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }

        public List<T> Postorder()
        {
            if (this.Root == null)
            {
                return new List<T>();
            }
            return Postorder(this.Root);
        }

        private List<T> Postorder(TreeNode<T> node)
        {
            var list = new List<T>();
            if (!(node == null))
            {
                if (!(node.Left == null))
                {
                    list.AddRange(Postorder(node.Left));
                }
                if (!(node.Right == null))
                {
                    list.AddRange(Postorder(node.Right));
                }
                list.Add(node.Val);
            }
            return list;
        }
    }
}
