using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests.BinarySearchTreeTests
{
    public class BinarySearchTreeStringTests : TreeTests<string>
    {
        protected override ITree<string> CreateTree()
        {
            return new BinarySearchTree<string>();
        }

        public static new IEnumerable<object[]> GetInsertCases()
        {
            yield return new object[]
            {
                new TreeTestCase<string>(
                    initialItems: new List<string> { "Hello", "cat", "dog" },
                    testProcedureItems: new List<string> { "airplane", "train" },
                    expectedItems: new List<string> { "airplane", "cat", "dog", "Hello", "train" }
                )
            };
        }

        [Theory]
        [MemberData(nameof(GetInsertCases))]
        public void InsertAndTraverse_Int_ShouldMatchExpected(TreeTestCase<string> testCase)
        {
            InsertAndTraverse_ShouldMatchExpected(testCase);
        }
    }
}
