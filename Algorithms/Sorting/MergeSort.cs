using AlgoLibrary.Interfaces;
using System;
using System.Linq;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class MergeSort : ISortingAlgo
    {
        public void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>
        {
            MergeIt(array, 0, array.Length, compare);
        }

        private void MergeIt<T>(T[] array, int min_idx, int max_idx, Func<T, T, bool> compare) where T : IComparable<T>
        {
            if (min_idx >= max_idx)
                return;
            int middle_idx = (min_idx + max_idx) / 2;

            MergeIt(array, min_idx, middle_idx, compare);
            MergeIt(array, middle_idx + 1, max_idx, compare);
            SortIt(array, min_idx, middle_idx, max_idx, compare);
        }

        private void SortIt<T>(T[] array, int min, int middle, int max, Func<T, T, bool> compare)
        {
            T[] left = array.Skip(min).Take(middle - min + 1).ToArray();
            T[] right = array.Skip(middle + 1).Take(max - middle).ToArray();
            int i = 0, j = 0, k = min;

            while (i < left.Length && j < right.Length)
            {
                if (compare(left[i], right[j]))
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }

            while (i < left.Length)
                array[k++] = left[i++];

            while (j < right.Length)
                array[k++] = right[j++];
        }
    }
}
