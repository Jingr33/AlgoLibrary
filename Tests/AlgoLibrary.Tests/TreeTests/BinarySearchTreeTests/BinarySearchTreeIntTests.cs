using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests.BinarySearchTreeTests
{
    public class BinarySearchTreeIntTests : TreeTests<int>
    {
        protected override ITree<int> CreateTree()
        {
            return new BinarySearchTree<int>();
        }

        public static new IEnumerable<object[]> GetInsertCases()
        {
            yield return new object[]
            {
                new TreeTestCase<int>(
                    initialItems: new List<int> { 5, 2, 8, 25, 26 },
                    testProcedureItems: new List<int> { 1, 7 },
                    expectedItems: new List<int> { 1, 2, 5, 7, 8, 25, 26 }
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
                    initialItems: new List<int> { 5, 2, 8, 9, 11, 1, 3 },
                    testProcedureItems: new List<int> { 1, 8, 5 },
                    expectedItems: new List<int> { 2, 3, 9, 11 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetRemoveCases))]
        public void Remove_Int_ShouldMatchExpected(TreeTestCase<int> testCase)
        {
            Remove_ShouldMatchExpected(testCase);
        }

        public static IEnumerable<object[]> GetTryGetMaxCases()
        {
            yield return new object[]
            {
                new TreeTestCase<int>(
                    initialItems: new List<int> { 5, 2, 8, 9, 11, 1, 3 },
                    testProcedureItems: new List<int> { },
                    expectedItems: new List<int> { 11 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetTryGetMaxCases))]
        public void TryGetMax_Int_ShouldMatchExpected(TreeTestCase<int> testCase)
        {
            TryGetMax_ShouldMatchExpected(testCase);
        }

        public static IEnumerable<object[]> GetTryGetMinCases()
        {
            yield return new object[]
            {
                new TreeTestCase<int>(
                    initialItems: new List<int> { 5, 2, 8, 9, 11, 1, 3 },
                    testProcedureItems: new List<int> { },
                    expectedItems: new List<int> { 1 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetTryGetMinCases))]
        public void TryGetMin_Int_ShouldMatchExpected(TreeTestCase<int> testCase)
        {
            TryGetMin_ShouldMatchExpected(testCase);
        }

    }
}
