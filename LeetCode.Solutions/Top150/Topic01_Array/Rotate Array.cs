namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            int i = 0;
            int j = nums.Length - 1;
            k = k % nums.Length;
            while (i < j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }

            i = 0;
            j = k - 1;
            while (i < j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }
            i = k;
            j = nums.Length - 1;

            while (i < j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }
        }
    }
}
