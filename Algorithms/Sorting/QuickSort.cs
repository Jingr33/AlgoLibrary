using AlgoLibrary.Interfaces;
using System;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class QuickSort : ISortingAlgo
    {
        public void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>
        {
            QuickSortIt(array, 0, array.Length - 1, compare);
        }

        private void QuickSortIt<T>(T[] array, int low, int high, Func<T, T, bool> compare) where T : IComparable<T>
        {
            if (low >= high)
                return;
            int pivot_idx = Partition(array, low, high, compare);

            QuickSortIt(array, low, pivot_idx - 1, compare);
            QuickSortIt(array, pivot_idx + 1, high, compare);
        }

        private int Partition<T>(T[] array, int low, int high, Func<T, T, bool> compare) where T : IComparable<T>
        {
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (compare(array[j], array[high]))
                {
                    i++;
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            T pivot_temp = array[high];
            array[high] = array[i + 1];
            array[i + 1] = pivot_temp;

            return i + 1;
        }
    }
}
