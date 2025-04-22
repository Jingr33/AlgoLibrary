using AlgoLibrary.Algorithms.Trees;
using AlgoLibrary.Interfaces;

namespace AlgoLibrary.Tests.TreeTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Insert_ShouldCreateRootNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            bst.Insert(1);

            int[] expected = { 1 };
            int[] values = bst.Traverse();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void Insert_ShouldAddLeftChild()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            bst.Insert(2);
            bst.Insert(1);

            int[] expected = { 1, 2 };
            int[] values = bst.Traverse();

            Assert.Equal(expected, values);

        }

        [Fact]
        public void Insert_ShouldAddRightChild()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            bst.Insert(2);
            bst.Insert(3);

            int[] expected = { 2, 3 };
            int[] values = bst.Traverse();

            Assert.Equal(expected, values);

        }

        [Fact]
        public void Create_CreateWholeTreeStructure()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 5, 9, 7, 3, 1, 4, 6, };
            int[] expected = { 1, 3, 4, 5, 6, 7, 9 };

            bst.Create(input);
            int[] nodes = bst.Traverse();

            Assert.Equal(nodes, expected);
        }

        [Fact]
        public void Remove_ShouldRemoveLeafNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16};
            int[] expected = { 1, 2, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(3);
            int[] values = bst.Traverse();

            Assert.Equal(expected, values);
        }

        [Fact]
        public void Remove_ShouldRemoveOneLeftChildNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int[] expected = { 1, 2, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(3);
            int[] values = bst.Traverse();

            Assert.Equal(values, expected);

        }

        [Fact]
        public void Remove_ShouldRemoveOneRightChildNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 3, 5, 7, 10, 12, 14, 16 };
            int[] expected = { 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(2);
            int[] values = bst.Traverse();

            Assert.Equal(values, expected);

        }

        [Fact]
        public void Remove_ShouldRemoveInnerNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 5, 7, 10, 12, 14, 16 };
            int[] expected = { 1, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(2);
            int[] values = bst.Traverse();

            Assert.Equal(values, expected);

        }

        [Fact]
        public void Remove_ShouldTryToRemoveUnexistingNode()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(17);
            int[] values = bst.Traverse();

            Assert.Equal(values, expected);
        }

        [Fact]
        public void Remove_ShouldRemoveRoot()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12, 13, 14, 15, 16 };
            bst.Create(input);

            bst.Remove(9);
            int[] values = bst.Traverse();

            Assert.Equal(values, expected);
        }

        [Fact]
        public void GetMax_ShouldFindMaximumOfWholeBST()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int expected = 16;

            bst.Create(input);
            int? max_value = bst.GetMax();

            Assert.Equal(expected, max_value);
        }

        [Fact]
        public void GetMax_ShouldFindMaximumOfSubTree()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int expected = 16;

            bst.Create(input);
            int? max_value = bst.GetMax(bst.GetRootNode().GetRightChild());

            Assert.Equal(expected, max_value);
        }

        [Fact]
        public void GetMax_EmptyTree_ShouldReturnNull()
        {
            ITree<int> bst = new BinarySearchTree<int>();

            int? max_value = bst.GetMax();

            Assert.Null(max_value);

        }

        [Fact]
        public void GetMin_ShouldFindMinimumOfWholeBST()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int expected = 1;

            bst.Create(input);
            int? max_value = bst.GetMin();

            Assert.Equal(expected, max_value);

        }

        [Fact]
        public void GetMin_ShouldFindMinimumOfSubTree()
        {
            ITree<int> bst = new BinarySearchTree<int>();
            int[] input = { 9, 4, 13, 2, 6, 11, 15, 1, 3, 5, 7, 10, 12, 14, 16 };
            int expected = 1;

            bst.Create(input);
            int? max_value = bst.GetMin(bst.GetRootNode().GetLeftChild());

            Assert.Equal(expected, max_value);
        }

        [Fact]
        public void GetMin_EmptyTree_ShouldReturnNull()
        {
            ITree<int> bst = new BinarySearchTree<int>();

            int? max_value = bst.GetMin();

            Assert.Null(max_value);

        }
    }
}
