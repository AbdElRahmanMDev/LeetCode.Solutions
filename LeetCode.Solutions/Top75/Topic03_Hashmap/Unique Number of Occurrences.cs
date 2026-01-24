namespace LeetCode.Solutions.Top75.Topic03_Hashmap
{
    internal class Unique_Number_of_Occurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict[item] = 1;
            }

            var set = new HashSet<int>(dict.Values);
            return set.Count == dict.Count;
        }
    }
}
