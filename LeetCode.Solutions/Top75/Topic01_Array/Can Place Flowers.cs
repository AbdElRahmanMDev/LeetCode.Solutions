namespace LeetCode.Solutions.Top75.Topic01_Array
{
    internal class Can_Place_Flowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                bool left = (i == 0 || flowerbed[i - 1] == 0);
                bool right = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);

                if (left && right && flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n <= 0;
        }
    }
}
