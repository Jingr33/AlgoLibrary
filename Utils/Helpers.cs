namespace AlgoLibrary.Utils
{
    public class Helpers
    {
        public static int FindExtremeIndex(int[] array, bool findMaximum = true)
        {
            int extremeIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if ((findMaximum && array[i] > array[extremeIdx])
                    || (!findMaximum && array[i] < array[extremeIdx]))
                    extremeIdx = i;
            }
            return extremeIdx;
        }
    }
}
