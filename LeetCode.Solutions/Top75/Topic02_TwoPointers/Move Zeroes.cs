namespace LeetCode.Solutions.Top75.Topic02_TwoPointers
{
    internal class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int nonzero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[nonzero];
                    nums[nonzero] = temp;
                    nonzero++;

                }
            }

        }
    }
}
