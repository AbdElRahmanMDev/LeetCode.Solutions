namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            //    ["flower","flow","flight"]


            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (var str in strs)
                {
                    if (str.Length == i || str[i] != strs[0][i])
                        return str.Substring(0, i);
                }
            }
            return strs[0];
        }
    }
}
