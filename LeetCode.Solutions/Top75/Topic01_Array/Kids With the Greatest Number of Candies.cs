namespace LeetCode.Solutions.Top75.Topic01_Array
{
    internal class Kids_With_the_Greatest_Number_of_Candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            List<bool> res = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies < max)
                {
                    res.Add(false);
                }
                else
                {
                    res.Add(true);
                }
            }

            return res;


        }
    }
}
