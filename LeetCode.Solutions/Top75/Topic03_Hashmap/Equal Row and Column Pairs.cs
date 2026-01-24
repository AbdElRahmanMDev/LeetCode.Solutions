namespace LeetCode.Solutions.Top75.Topic03_Hashmap
{
    internal class Equal_Row_and_Column_Pairs
    {
        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                string res = string.Join(",", grid[i]);
                if (!dict.ContainsKey(res))
                {
                    dict[res] = 1;
                }
                else
                {
                    dict[res]++;
                }
            }

            for (int j = 0; j < n; j++)
            {
                List<int> count = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    count.Add(grid[i][j]);

                }
                string res = string.Join(",", count);
                if (dict.ContainsKey(res))
                {
                    ans += dict[res];
                }
            }

            return ans;

        }
    }
}
