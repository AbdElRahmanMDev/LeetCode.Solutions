namespace LeetCode.Solutions.Top150.Topic010_Matrix
{
    internal class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
            Dictionary<string, HashSet<char>> sqrs = new Dictionary<string, HashSet<char>>();

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    char value = board[r][c];
                    string sqrkey = $"{r / 3},{c / 3}";
                    if (value == '.')
                        continue;
                    if (!rows.ContainsKey(r))
                    {
                        rows[r] = new HashSet<char>();
                    }
                    if (!cols.ContainsKey(c))
                    {
                        cols[c] = new HashSet<char>();
                    }
                    if (!sqrs.ContainsKey(sqrkey))
                    {
                        sqrs[sqrkey] = new HashSet<char>();
                    }

                    if (!rows[r].Add(value) || !cols[c].Add(value) || !sqrs[sqrkey].Add(value))
                        return false;
                }
            }
            return true;

        }
    }
}
