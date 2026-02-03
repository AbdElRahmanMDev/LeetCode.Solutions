namespace LeetCode.Solutions.Top75.Topic05_SlidingWindow
{
    internal class Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
    {
        public int MaxVowels(string s, int k)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            int max = 0;
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                    counter++;
            }
            max = counter;

            for (int j = k; j < s.Length; j++)
            {
                if (vowels.Contains(s[j - k]))
                    counter--;
                if (vowels.Contains(s[j]))
                    counter++;
                max = Math.Max(counter, max);


            }
            return max;
        }
    }
}
