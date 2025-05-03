using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests
{
    public abstract class TreeTests<T> where T : IComparable<T> 
    {
        protected abstract ITree<T> CreateTree();

        public void InsertAndTraverse_ShouldMatchExpected(TreeTestCase<T> testCase)
        {
            var tree = CreateTree();

            tree.Create(testCase.InitialItems);
            var result2 = tree.Traverse();

            foreach (var item in testCase.TestProcedureItems)
                tree.Insert(item);

            var result = tree.Traverse();
            Assert.Equal(testCase.ExpectedItems, result);
        }

        public void Remove_ShouldMatchExpected(TreeTestCase<T> testCase)
        {
            var tree = CreateTree();

            tree.Create(testCase.InitialItems);
            var result2 = tree.Traverse();

            foreach (var item in testCase.TestProcedureItems)
                tree.Remove(item);

            var result = tree.Traverse();
            Assert.Equal(testCase.ExpectedItems, result);
        }

        public void TryGetMax_ShouldMatchExpected(TreeTestCase<T> testCase)
        {
            var tree = CreateTree();

            tree.Create(testCase.InitialItems);
            bool max_found = tree.TryGetMax(out var maximum);

            Assert.True(max_found);
            Assert.Equal(testCase.ExpectedItems[0], maximum);
        }

        public void TryGetMin_ShouldMatchExpected(TreeTestCase<T> testCase)
        {
            var tree = CreateTree();

            tree.Create(testCase.InitialItems);
            bool min_found = tree.TryGetMin(out var minimum);

            Assert.True(min_found);
            Assert.Equal(testCase.ExpectedItems[0], minimum);
        }
    }
}
