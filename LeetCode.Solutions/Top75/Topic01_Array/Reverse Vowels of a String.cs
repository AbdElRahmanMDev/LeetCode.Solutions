using System.Text;

namespace LeetCode.Solutions.Top75.Topic01_Array
{
    internal class Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int i = 0;
            int j = s.Length - 1;

            StringBuilder res = new StringBuilder(s);

            while (i < j)
            {
                if (!vowels.Contains(res[i]))
                {
                    i++;
                    continue;
                }
                if (!vowels.Contains(res[j]))
                {
                    j--;
                    continue;
                }
                else
                {
                    res[i] = res[j];
                    res[j] = s[i];
                    i++;
                    j--;
                }

            }

            return res.ToString();

        }
    }
}
