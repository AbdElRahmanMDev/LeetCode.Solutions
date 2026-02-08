namespace LeetCode.Solutions.Top150.Topic03_Hashmap
{
    internal class Happy_Number
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            while (n != 1)
            {
                if (set.Contains(n))
                    return false;
                set.Add(n);
                n = Fun(n);
            }
            return true;
        }

        public int Fun(int n)
        {
            var current = 0;
            while (n != 0)
            {
                var digit = n % 10;
                current += digit * digit;
                n = n / 10;
            }
            return current;
        }
    }
}
