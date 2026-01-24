namespace LeetCode.Solutions.Top75.Topic02_TwoPointers
{
    internal class Max_Number_of_K_Sum_Pairs
    {
        public int MaxOperations(int[] nums, int k)
        {
            int i = 0;
            int j = nums.Length - 1;
            Array.Sort(nums);
            int count = 0;
            while (i < j)
            {
                int sum = nums[i] + nums[j];

                if (sum == k)
                {
                    i++;
                    j--;
                    count++;
                }
                else if (sum < k)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return count;

        }

    }
}
