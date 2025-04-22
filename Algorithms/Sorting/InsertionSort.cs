using AlgoLibrary.Interfaces;
using System;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class InsertionSort : ISortingAlgo
    {
        public void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && compare(key, array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
