namespace LeetCode.Solutions.Top75.Topic03_Hashmap
{
    internal class Find_the_Difference_of_Two_Arrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);
            return new List<IList<int>> { set1.Where(x => !set2.Contains(x)).ToList(), set2.Where(x => !set1.Contains(x)).ToList() };
        }
    }
}
