namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Ransom_Note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] res = new int[26];

            for (int i = 0; i < magazine.Length; i++)
            {
                res[magazine[i] - 'a']++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                res[ransomNote[i] - 'a']--;
                if (res[ransomNote[i] - 'a'] < 0)
                    return false;
            }
            return true;

        }
    }
}
