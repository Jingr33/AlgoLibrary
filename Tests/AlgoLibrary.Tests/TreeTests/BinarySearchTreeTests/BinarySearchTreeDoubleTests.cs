using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests.BinarySearchTreeTests
{
    public class BinarySearchTreedoubleTests : TreeTests<double>
    {
        protected override ITree<double> CreateTree()
        {
            return new BinarySearchTree<double>();
        }

        public static new IEnumerable<object[]> GetInsertCases()
        {
            yield return new object[]
            {
                new TreeTestCase<double>(
                    initialItems: new List<double> { 3.14, 2.8965, 7.54 },
                    testProcedureItems: new List<double> { 9.585, 1.265 },
                    expectedItems: new List<double> { 1.265, 2.8965, 3.14, 7.54, 9.585 }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetInsertCases))]
        public void InsertAndTraverse_Int_ShouldMatchExpected(TreeTestCase<double> testCase)
        {
            InsertAndTraverse_ShouldMatchExpected(testCase);
        }
    }
}
