using System;

namespace AlgoLibrary.Interfaces
{
    public interface IIntSortingAlgo
    {
        void Sort(int[] array, Func<int, int, bool> compare);
    }
}
