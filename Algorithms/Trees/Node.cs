using System;

namespace AlgoLibrary.Algorithms.Trees
{
    public class Node<T> where T : IComparable<T>
    {
        private T _data;
        private Node<T> _leftChild;
        private Node<T> _rightChild;
        private Node<T> _parent;
        private int _height = 1;

        public Node(T data)
        {
            _data = data;
        }

        public bool IsLeftChild()
        {
            if (_parent != null && _parent.GetLeftChild() == this)
                return true;
            return false;
        }

        public void SetData(T data)
        {
            _data = data;
        }

        public T GetData()
        {
            return _data;
        }

        public Node<T> GetLeftChild()
        {
            return _leftChild;
        }

        public void SetLeftChild(Node<T> leftChild)
        {
            _leftChild = leftChild;
        }

        public void SetRightChild(Node<T> rightChild)
        {
            _rightChild = rightChild;
        }

        public Node<T> GetRightChild()
        {
            return _rightChild;
        }

        public void SetParent(Node<T> parent)
        {
            _parent = parent;
        }

        public Node<T> GetParent()
        {
            return _parent;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public int GetHeight()
        {
            return _height;
        }
    }
}
