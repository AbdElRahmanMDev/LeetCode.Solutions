namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {

            if (s.Length != t.Length)
                return false;

            var mapST = new Dictionary<char, char>(); // s -> t
            var mapTS = new Dictionary<char, char>(); // t -> s

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                char b = t[i];

                if (mapST.TryGetValue(a, out char mappedDb))
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
