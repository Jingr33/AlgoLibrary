using AlgoLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace AlgoLibrary.Algorithms.Trees
{
    public class BinarySearchTree<T> : ITree<T> where T : struct, IComparable<T>
    {
        private Node<T> root;

        public T? GetMax()
        {
            if (IsEmpty())
                return null;

            Node<T> node = root;
            return GetMax(node);
        }

        public T GetMax(Node<T> node)
        {
            while (node.GetRightChild() != null)
                node = node.GetRightChild();
            return node.GetData();

        }

        public T? GetMin()
        {
            if (IsEmpty())
                return null;

            Node<T> node = root;
            return GetMin(node);
        }
        public T GetMin(Node<T> node)
        {

            while (node.GetLeftChild() != null)
                node = node.GetLeftChild();
            return node.GetData();
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public T[] Traverse()
        {
            List<T> nodesList = new List<T>();
            TraverseInOrder(root, nodesList);
            return nodesList.ToArray();
        }

        public void Insert(T item)
        {
            if (IsEmpty())
                root = new Node<T>(item);
            else
                Insert(item, root);
        }

        public void Create(T[] array)
        {
            foreach (T item in array)
                Insert(item);
        }

        public void Remove(T item)
        {
            root = Remove(item, root);
        }

        private void TraverseInOrder(Node<T> node, List<T> data)
        {
            if (node != null)
            {
                TraverseInOrder(node.GetLeftChild(), data);
                data.Add(node.GetData());
                TraverseInOrder(node.GetRightChild(), data);
            }
        }

        private void Insert(T item, Node<T> node)
        {
            if (item.CompareTo(node.GetData()) < 0)
            {
                if (node.GetLeftChild() == null)
                {
                    Node<T> new_node = new Node<T>(item);
                    new_node.SetParent(node);
                    node.SetLeftChild(new_node);
                }
                else
                    Insert(item, node.GetLeftChild());

            }
            else if (item.CompareTo(node.GetData()) > 0)
            {
                if (node.GetRightChild() == null)
                {
                    Node<T> new_node = new Node<T>(item);
                    new_node.SetParent(node);
                    node.SetRightChild(new_node);
                }
                else
                    Insert(item, node.GetRightChild());
            }
        }

        private Node<T> Remove(T data, Node<T> node)
        {
            if (node == null)
                return null;

            if (data.CompareTo(node.GetData()) < 0)
                node.SetLeftChild(Remove(data, node.GetLeftChild()));
            else if (data.CompareTo(node.GetData()) > 0)
                node.SetRightChild(Remove(data, node.GetRightChild()));
            else
            {
                if (node.GetLeftChild() == null)
                    return node.GetRightChild();
                else if (node.GetRightChild() == null)
                    return node.GetLeftChild();

                node.SetData(GetMax(node.GetLeftChild()));
                node.SetLeftChild(Remove(node.GetData(), node.GetLeftChild()));
            }
            return node;
        }

        public Node<T> GetRootNode()
        {
            return root;
        }
    }
}
