namespace LeetCode.Solutions.Shared.Topic02_TwoPointers
{
    internal class Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int maxArea = int.MinValue;
            while (i < j)
            {
                maxArea = Math.Max(Math.Min(height[i], height[j]) * (j - i), maxArea);

                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return maxArea;

        }
    }
}