using AlgoLibrary.Interfaces;
using System;
using System.Collections.Generic;
namespace AlgoLibrary.Algorithms.Sorting
{
    public class SelectionSort : ISortingAlgo
    {
        public void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int extreme_idx = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (compare(array[j], array[extreme_idx]))
                        extreme_idx = j;
                }
                T temp = array[i];
                array[i] = array[extreme_idx];
                array[extreme_idx] = temp;
            }
        }
    }
}
