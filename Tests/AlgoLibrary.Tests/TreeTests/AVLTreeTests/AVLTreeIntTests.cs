using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests.AVLTreeTests
{
    public class AVLTreeIntTests : TreeTests<int>
    {
        protected override ITree<int> CreateTree()
        {
            return new AVLTree<int>();
        }

        public static IEnumerable<object[]> GetInsertCases()
        {
            yield return new object[]
            {
                new TreeTestCase<int>(
                    initialItems: new List<int> { 5, 2, 8, 25, 26, 28 },
                    testProcedureItems: new List<int> { 1, 7, 27 },
                    expectedItems: new List<int> { 1, 2, 5, 7, 8, 25, 26, 27, 28 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetInsertCases))]
        public void InsertAndTraverse_Int_ShouldMatchExpected(TreeTestCase<int> testCase)
        {
            InsertAndTraverse_ShouldMatchExpected(testCase);
        }

        public static IEnumerable<object[]> GetRemoveCases()
        {
            yield return new object[]
            {
                new TreeTestCase<int>(
                    initialItems: new List<int> { 5, 2, 8, 9, 11, 1, 25, 26 },
                    testProcedureItems: new List<int> { 9, 2, 26 },
                    expectedItems: new List<int> { 1, 5, 8, 11, 25 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetRemoveCases))]
        public void Remove_Int_ShouldMatchExpected(TreeTestCase<int> testCase)
        {
            Remove_ShouldMatchExpected(testCase);
        }
    }

}

