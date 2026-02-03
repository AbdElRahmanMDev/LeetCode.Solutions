namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Remove_Duplicates_from_Sorted_Array_II
    {

        public int RemoveDuplicates(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                    if (dict[nums[i]] <= 2)
                    {
                        nums[result] = nums[i];
                        result++;
                    }
                }
                else
                {
                    nums[result] = nums[i];
                    result++;
                    dict[nums[i]] = 1;
                }
            }
            return result;
        }

    }
}
