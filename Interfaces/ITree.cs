
using AlgoLibrary.Algorithms.Trees;
using System;

namespace AlgoLibrary.Interfaces
{
    public interface ITree<T> where T : struct, IComparable<T>
    {
        void Create(T[] array);
        void Insert(T item);
        void Remove(T item);
        T[] Traverse();
        T? GetMax();
        T GetMax(Node<T> node);
        T? GetMin();
        T GetMin(Node<T> node);
        bool IsEmpty();
        Node<T> GetRootNode();
    }
}
