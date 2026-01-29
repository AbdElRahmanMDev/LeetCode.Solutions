namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;
            foreach (var s in set)
            {
                if (!set.Contains(s - 1))
                {
                    int length = 1;
                    while (set.Contains(s + length))
                    {
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }
    }
}
