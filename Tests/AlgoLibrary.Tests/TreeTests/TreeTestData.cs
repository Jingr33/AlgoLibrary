using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests
{
    public class TreeTestData
    {
        public static IEnumerable<object[]> GetTestCases()
        {
            // Test case for BinarySearchTree
            yield return new object[]
            {
            new Func<ITree<int>>(() => new BinarySearchTree<int>()),
            new TreeTestCase<int>(
                initialItems: new List<int> { 5, 2, 8 },
                testProcedureItems: new List<int> { 1, 7 },
                expectedItems: new List<int> { 1, 2, 5, 7, 8 }
            )
            };

            // Test case for AVLTree
            yield return new object[]
            {
            new Func<ITree<int>>(() => new AVLTree<int>()),
            new TreeTestCase<int>(
                initialItems: new List<int> { 10, 20, 30 },
                testProcedureItems: new List<int> { 5, 25 },
                expectedItems: new List<int> { 5, 10, 20, 25, 30 }
            )
            };
        }
    }
}
