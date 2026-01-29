

namespace LeetCode.Solutions.Top150.Topic05_Sliding_Window;

internal class Longest_Substring_Without_Repeating_Characters
{
    public int LengthOfLongestSubstring(string s)
    {
        int longest = 0;
        int l = 0;
        HashSet<int> set = new HashSet<int>();
        for (int r = 0; r < s.Length; r++)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            longest = Math.Max(longest, r - l + 1);
        }

        return longest;
    }
}
