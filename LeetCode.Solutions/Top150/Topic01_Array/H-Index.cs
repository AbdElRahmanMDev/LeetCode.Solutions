namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class H_Index
    {
        public int HIndex(int[] citations)
        {
            //[0,1,3,5,6]
            int n = citations.Length;
            Array.Sort(citations);
            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= n - i) return n - i;
            }
            return 0;
        }
    }
}
