using AlgoLibrary.Interfaces;
using AlgoLibrary.Algorithms.Sorting;

namespace AlgoLibrary.Tests.Sorting
{
    public class MergeSortTests
    {
        private ISortingAlgo _sorter = new MergeSort();

        [Fact]
        public void Sort_SortInArrAscending()
        {
            int[] input = { 5, 3, 4, 2, 9, 7, 1, 8, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            _sorter.Sort(input, (a, b) => a < b);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_SortStringArrAscending()
        {
            string[] input = { "here", "if", "how", "well", "car", "cat", "if", "only", "people", "about" };
            string[] expected = { "about", "car", "cat", "here", "how", "if", "if", "only", "people", "well" };

            _sorter.Sort(input, (a, b) => String.Compare(a, b) < 0);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_SortCharArrAscending()
        {
            char[] input = { 'd', 'b', 'c', 'a' };
            char[] expected = { 'a', 'b', 'c', 'd' };

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

        [Fact]
        public void Sort_SortStringArrDescending()
        {
            string[] input = { "here", "if", "how", "well", "car", "cat", "if", "only", "people", "about" };
            string[] expected = { "well", "people", "only", "if", "if", "how", "here", "cat", "car", "about", };

            _sorter.Sort(input, (a, b) => String.Compare(a, b) > 0);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_SortCharArrDescending()
        {
            char[] input = { 'd', 'b', 'c', 'a' };
            char[] expected = { 'd', 'c', 'b', 'a' };

            _sorter.Sort(input, (a, b) => a > b);

            Assert.Equal(expected, input);
        }
    }
}
