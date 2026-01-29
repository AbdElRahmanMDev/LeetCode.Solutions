namespace LeetCode.Solutions.Top150.Topic05_Sliding_Window;

internal class Minimum_Size_Subarray_Sum
{
    public int MinSubArrayLen(int target, int[] nums)
    {

        int count = int.MaxValue;
        int l = 0;
        int sum = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];

            while (sum >= target)
            {
                count = Math.Min(count, (r - l) + 1);
                sum -= nums[l++];
            }




        }
        return count == int.MaxValue ? 0 : count;

    }
}
