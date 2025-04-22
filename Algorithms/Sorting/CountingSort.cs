using AlgoLibrary.Interfaces;
using AlgoLibrary.Utils;
using System;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class CountingSort : IIntSortingAlgo
    {
        public void Sort(int[] array, Func<int, int, bool> compare)
        {
            int min_idx = Helpers.FindExtremeIndex(array, false);
            int max_idx = Helpers.FindExtremeIndex(array, true);
            int[] counting = new int[array[max_idx] - array[min_idx] + 1];

            for (int i = 0; i < array.Length; i++)
                counting[array[i] - array[min_idx]]++;

            for (int j = 1; j < counting.Length; j++)
                counting[j] += counting[j - 1];

            int[] output = new int[array.Length];  
            for (int k = array.Length - 1; k >= 0; k--)
            {
                int current = array[k];
                int positionInArray = counting[current - array[min_idx]] - 1;
                output[positionInArray] = current;
                counting[current - array[min_idx]]--;
            }

            bool ascending = compare(1, 2);
            for (int l = 0; l < array.Length; l++)
            {
                if (ascending)
                    array[l] = output[l];
                else
                    array[l] = output[output.Length - 1 - l];
            }
        }
    }
}
