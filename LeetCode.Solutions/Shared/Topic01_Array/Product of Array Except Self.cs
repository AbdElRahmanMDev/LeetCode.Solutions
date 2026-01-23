namespace LeetCode.Solutions.Shared.Topic01_Array
{
    internal class Product_of_Array_Except_Self
    {
        // [1,2,3,4]
        // [1,1,2,6]
        // [24,12,4,1]
        // ------------
        // [24,12,8,6]
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int suffix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }
    }
}
