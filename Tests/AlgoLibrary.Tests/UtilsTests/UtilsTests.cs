using System;
using AlgoLibrary.Utils;

namespace AlgoLibrary.Tests.UtilsTests
{
    public class UtilsTests
    {
        [Fact]
        public void FindExtremeIndex_FindMinimum()
        {
            int[] input = { 8, 5, 1, 3, 7, 6, 4, 9, 4 };
            int max_index = Helpers.FindExtremeIndex(input, false);

            Assert.Equal(2, max_index);
        }

        [Fact]
        public void FindExtremeIndex_FindMaximum()
        {
            int[] input = { 8, 5, 1, 3, 7, 6, 4, 9, 4 };
            int min_index = Helpers.FindExtremeIndex(input);

            Assert.Equal(7, min_index);

        }
    }
}
