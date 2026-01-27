namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Word_Pattern
    {
        public bool WordPattern(string pattern, string s)
        {
            var mapST = new Dictionary<char, string>();
            var mapTS = new Dictionary<string, char>(); // t -> s

            //    ["dog","cat","cat","dog"]
            //    ["abba"]
            string[] words = s.Split(' ');   // ["dog","cat","cat","dog"]
            if (words.Length != pattern.Length)
                return false;
            for (int i = 0; i < words.Length; i++)
            {
                char a = pattern[i];
                string b = words[i];
                if (mapST.TryGetValue(a, out string mappedDb))
                {
                    if (mappedDb != b) return false;
                }
                else
                {
                    mapST[a] = b;
                }
                if (mapTS.TryGetValue(b, out char mappedA))
                {
                    if (mappedA != a) return false;
                }
                else
                {
                    mapTS[b] = a;
                }

            }

            return true;
        }
    }
}
