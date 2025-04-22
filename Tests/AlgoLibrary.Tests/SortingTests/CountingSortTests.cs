using AlgoLibrary.Interfaces;
using AlgoLibrary.Algorithms.Sorting;

namespace AlgoLibrary.Tests.Sorting
{
    public class CountingSortTests
    {
        private IIntSortingAlgo _sorter = new CountingSort();

        [Fact]
        public void Sort_SortInArrAscending()
        {
            int[] input = { 5, 3, 4, -5, 2, 9, 7, 1, 8, 6 };
            int[] expected = { -5, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            _sorter.Sort(input, (a, b) => a < b);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_SortInArrDescending()
        {
            int[] input = { 5, 3, 4, 2, 9, 7, 1, 8, 6 };
            int[] expected = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

           _sorter.Sort(input, (a, b) => a > b);

            Assert.Equal(expected, input);

        }
    }
}
