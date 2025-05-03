using AlgoLibrary.Algorithms.Trees;
using System;
using System.Collections.Generic;

namespace AlgoLibrary.Interfaces
{
    public interface ITree<T> where T : IComparable<T>
    {
        void Create(List<T> array);
        void Insert(T item);
        void Remove(T item);
        T[] Traverse();
        bool TryGetMax(out T result);
        T GetMax(Node<T> node);
        bool TryGetMin(out T result);
        T GetMin(Node<T> node);
        bool IsEmpty();
        Node<T> GetRootNode();
    }
}
