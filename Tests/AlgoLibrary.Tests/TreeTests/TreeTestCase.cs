namespace AlgoLibrary.Tests.TreeTests
{
    public class TreeTestCase<T>
    {
        public List<T> InitialItems { get; set; } = new List<T>();
        public List<T> TestProcedureItems { get; set;} = new List<T>();
        public List<T> ExpectedItems { get; set; } = new List<T>();

        public TreeTestCase(List<T> initialItems, List<T> testProcedureItems, List<T> expectedItems)
        {
            InitialItems = initialItems;
            TestProcedureItems = testProcedureItems;
            ExpectedItems = expectedItems;
        }
    }
}
