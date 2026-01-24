namespace LeetCode.Solutions.Top75.Topic03_Hashmap
{
    internal class Determine_if_Two_Strings_Are_Close
    {
        public bool CloseStrings(string word1, string word2)
        {
            //Close If
            //both have the same Length
            //both have the same Characters
            //Both have the same frequency
            //word1 = "abc", word2 = "bca"
            if (word1.Length != word2.Length) return false;

            int[] frequency1 = new int[26];
            int[] frequency2 = new int[26];

            for (int index = 0; index < word1.Length; index++)
            {
                frequency1[word1[index] - 'a']++;
                frequency2[word2[index] - 'a']++;
            }

            for (int index = 0; index < 26; index++)
            {
                if (frequency1[index] == 0 && frequency2[index] != 0)
                    return false;
                if (frequency1[index] != 0 && frequency2[index] == 0)
                    return false;
            }

            Array.Sort(frequency1);
            Array.Sort(frequency2);

            return frequency1.SequenceEqual(frequency2);


        }
    }
}
