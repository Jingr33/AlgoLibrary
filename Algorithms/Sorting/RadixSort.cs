using AlgoLibrary.Interfaces;
using AlgoLibrary.Utils;
using System;
using System.Collections.Generic;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class RadixSort : IIntSortingAlgo
    {
        public void Sort(int[] array, Func<int, int, bool> compare)
        {
            List<int> positiveList = new List<int>();
            List<int> negativeList = new List<int>();
            foreach (int num in array)
            {
                if (num >= 0)
                    positiveList.Add(num);
                else
                    negativeList.Add(-num);
            }
            int[] positive = positiveList.ToArray();
            int[] negative = negativeList.ToArray();

            UseRadixSort(positive);
            UseRadixSort(negative);

            for (int i = 0; i < negative.Length; i++)
                negative[i] = -negative[i];

            Array.Reverse(negative);
            for (int i = 0; i < negative.Length; i++)
                array[i] = negative[i];

            for (int i = 0; i < positive.Length; i++)
                array[i + negative.Length] = positive[i];

            if (compare(2, 1))
                Array.Reverse(array);
        }

        private void UseRadixSort(int[] array)
        {
            int max_value = array[Helpers.FindExtremeIndex(array, true)];
            for (int exp = 1; max_value / exp > 0; exp *= 10)
                CountingSort(array, exp);
        }

        private void CountingSort(int[] array, int exp)
        {
            int[] counting = new int[10];

            for (int i = 0; i < array.Length; i++)
                counting[array[i] / exp % 10]++;

            for (int j = 1; j < 10; j++)
                counting[j] += counting[j - 1];

            int[] output = new int[array.Length];
            for (int k = array.Length - 1; k >= 0; k--)
            {
                int current = array[k];
                int positionInArray = counting[current / exp % 10] - 1;
                output[positionInArray] = current;
                counting[current / exp % 10]--;
            }

            for (int l = 0; l < array.Length; l++)
                array[l] = output[l];
        }

    }
}
