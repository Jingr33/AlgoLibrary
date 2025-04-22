using AlgoLibrary.Interfaces;
using AlgoLibrary.Algorithms.Sorting;

namespace AlgoLibrary.Tests.Sorting
{
    public class RadixSortTests
    {
        private IIntSortingAlgo _sorter = new RadixSort();

        [Fact]
        public void Sort_SortInArrAscending()
        {
            int[] input = { 513, 345, 498, -513, -1, -52, 22, 9, 74, 197, 9, 873, 676 };
            int[] expected = { -513, -52, -1, 9, 9, 22, 74, 197, 345, 498, 513, 676, 873 };

            _sorter.Sort(input, (a, b) => a < b);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_SortInArrDescending()
        {
            int[] input = { 513, 345, 498, -513, -1, -52, 22, 9, 74, 197, 9, 873, 676 };
            int[] expected = { 873, 676, 513, 498, 345, 197, 74, 22, 9, 9, -1, -52, -513 };

           _sorter.Sort(input, (a, b) => a > b);

            Assert.Equal(expected, input);

        }
    }
}
