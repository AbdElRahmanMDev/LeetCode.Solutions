namespace LeetCode.Solutions.Top75.Topic05_SlidingWindow
{
    internal class Maximum_Average_Subarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            int maxsum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            maxsum = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i - k] + nums[i];
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
            }

            return (double)maxsum / k;
        }
    }
}
