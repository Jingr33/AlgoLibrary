using System;

namespace AlgoLibrary.Algorithms.Trees
{
    public class AVLTree<T> : BinarySearchTree<T> where T : IComparable<T>
    {
        protected override Node<T> InsertNode(T item, Node<T> node)
        {
            if (node == null)
                return new Node<T>(item);

            if (item.CompareTo(node.GetData()) < 0)
                node.SetLeftChild(InsertNode(item, node.GetLeftChild()));
            else if (item.CompareTo(node.GetData()) > 0)
                node.SetRightChild(InsertNode(item, node.GetRightChild()));
            else
                return node;

            UpdateHeight(node);
            return ApplyRotation(node);
        }

        protected override Node<T> RemoveNode(T data, Node<T> node)
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

            UpdateHeight(node);
            return ApplyRotation(node);
        }

        private void UpdateHeight(Node<T> node)
        {
            int maxHeight = Math.Max(Height(node.GetLeftChild()), Height(node.GetRightChild()));
            node.SetHeight(maxHeight + 1);
        }

        private int Height(Node<T> node)
        {
            return node != null ? node.GetHeight() : 0;
        }

        private Node<T> ApplyRotation(Node<T> node)
        {
            int balance = Balance(node);
            if (balance > 1)
            {
                if (Balance(node.GetLeftChild()) < 0)
                    node.SetLeftChild(RotateLeft(node.GetLeftChild()));
                return RotateRight(node);
            }
            if (balance < -1)
            {
                if (Balance(node.GetRightChild()) > 0)
                    node.SetRightChild(RotateRight(node.GetRightChild()));
                return RotateLeft(node);
            }
            return node;
        }

        private int Balance(Node<T> node)
        {
            return node != null ? Height(node.GetLeftChild()) - Height(node.GetRightChild()) : 0;
        }

        private Node<T> RotateLeft(Node<T> node)
        {
            Node<T> rightNode = node.GetRightChild();
            Node<T> centerNode = rightNode.GetLeftChild();
            rightNode.SetLeftChild(node);
            node.SetRightChild(centerNode);
            UpdateHeight(node);
            UpdateHeight(rightNode);
            return rightNode;
        }

        private Node<T> RotateRight(Node<T> node)
        {
            Node<T> leftNode = node.GetLeftChild();
            Node<T> centerNode = leftNode.GetRightChild();
            leftNode.SetRightChild(node);
            node.SetLeftChild(centerNode);
            UpdateHeight(node);
            UpdateHeight(leftNode);
            return leftNode;
        }
    }
}
