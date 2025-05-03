using AlgoLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace AlgoLibrary.Algorithms.Trees
{
    public class BinarySearchTree<T> : ITree<T> where T : IComparable<T>
    {
        protected Node<T> root;

        public Node<T> GetRootNode()
        {
            return root;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public virtual bool TryGetMax(out T result)
        {
            if (IsEmpty())
            {
                result = default;
                return false;
            }

            Node<T> node = root;
            result = GetMax(node);
            return true;
        }

        public virtual T GetMax(Node<T> node)
        {
            while (node.GetRightChild() != null)
                node = node.GetRightChild();
            return node.GetData();

        }

        public virtual bool TryGetMin(out T result)
        {
            if (IsEmpty())
            {
                result = default;
                return false;
            }

            Node<T> node = root;
            result = GetMin(node);
            return true;
        }
        public virtual T GetMin(Node<T> node)
        {

            while (node.GetLeftChild() != null)
                node = node.GetLeftChild();
            return node.GetData();
        }

        public void Create(List<T> array)
        {
            foreach (T item in array)
                Insert(item);
        }

        public virtual T[] Traverse()
        {
            List<T> nodesList = new List<T>();
            TraverseInOrder(root, nodesList);
            return nodesList.ToArray();
        }

        protected virtual void TraverseInOrder(Node<T> node, List<T> data)
        {
            if (node != null)
            {
                TraverseInOrder(node.GetLeftChild(), data);
                data.Add(node.GetData());
                TraverseInOrder(node.GetRightChild(), data);
            }
        }

        public virtual void Insert(T item)
        {
            if (IsEmpty())
                root = new Node<T>(item);
            else
                root = InsertNode(item, root);
        }

        protected virtual Node<T> InsertNode(T item, Node<T> node)
        {
            if (node == null)
                return new Node<T>(item);

            if (item.CompareTo(node.GetData()) < 0)
                node.SetLeftChild(InsertNode(item, node.GetLeftChild()));
            else if (item.CompareTo(node.GetData()) > 0)
                node.SetRightChild(InsertNode(item, node.GetRightChild()));
            return node;
        }

        public virtual void Remove(T item)
        {
            root = RemoveNode(item, root);
        }

        protected virtual Node<T> RemoveNode(T data, Node<T> node)
        {
            if (node == null)
                return null;

            if (data.CompareTo(node.GetData()) < 0)
                node.SetLeftChild(RemoveNode(data, node.GetLeftChild()));
            else if (data.CompareTo(node.GetData()) > 0)
                node.SetRightChild(RemoveNode(data, node.GetRightChild()));
            else
            {
                if (node.GetLeftChild() == null)
                    return node.GetRightChild();
                else if (node.GetRightChild() == null)
                    return node.GetLeftChild();

                node.SetData(GetMax(node.GetLeftChild()));
                node.SetLeftChild(RemoveNode(node.GetData(), node.GetLeftChild()));
            }
            return node;
        }
    }
}
