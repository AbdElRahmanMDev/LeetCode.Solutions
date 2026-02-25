namespace LeetCode.Solutions.Top150.Topic09_Intervals
{
    internal class Merge_Intervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return new int[0][];
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> merged = new List<int[]>();
            int[] prev = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] interval = intervals[i];
                if (prev[1] >= interval[0])
                {
                    prev[1] = Math.Max(prev[1], interval[1]);
                }
                else
                {
                    merged.Add(prev);
                    prev = interval;
                }
            }

            merged.Add(prev);
            return merged.ToArray();
        }

    }
}
