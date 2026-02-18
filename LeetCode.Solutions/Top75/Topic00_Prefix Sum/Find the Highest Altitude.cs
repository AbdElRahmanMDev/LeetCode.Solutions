namespace LeetCode.Solutions.Top75.Topic00_Prefix_Sum
{
    internal class Find_the_Highest_Altitude
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int sum = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
