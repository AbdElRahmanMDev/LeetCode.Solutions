namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            foreach (var num in nums)
            {
                if (num != val)
                {
                    nums[result] = num;
                    result++;
                }
            }
            return result;
        }

    }
}
