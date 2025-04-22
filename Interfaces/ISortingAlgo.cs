using System;

namespace AlgoLibrary.Interfaces
{
    public interface ISortingAlgo
    {
        void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>;
    }
}
