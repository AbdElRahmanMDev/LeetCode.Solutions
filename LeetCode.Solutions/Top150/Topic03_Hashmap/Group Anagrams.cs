namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            foreach (var s in strs)
            {
                var character = s.ToCharArray();
                Array.Sort(character);
                var sortedstring = new String(character);
                if (!map.ContainsKey(sortedstring))
                {
                    map[sortedstring] = new List<string>();

                }
                map[sortedstring].Add(s);
            }

            var x = map.Select(x => x.Value).ToList();
            return x;
        }
    }
}
