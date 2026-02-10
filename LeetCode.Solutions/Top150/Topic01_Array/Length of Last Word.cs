namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int r = s.Length - 1;
            int count = 0;

            while (r >= 0 && s[r] != ' ')
            {
                count++;
                r--;
            }

            return count;
        }
    }
}
