using AlgoLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLibrary.Algorithms.Sorting
{
    public class BubbleSort : ISortingAlgo
    {
        public void Sort<T>(T[] array, Func<T, T, bool> compare) where T : IComparable<T>
        {
            bool sort_completed = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sort_completed = true;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (!compare(array[j], array[j + 1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        sort_completed = false;
                    }
                }

                if (sort_completed)
                    break;
            }
        }
    }
}
