namespace LeetCode.Solutions.Top75.Topic01_Array
{
    internal class String_Compression
    {
        public int Compress(char[] chars)
        {
            int i = 0;
            int index = 0;
            int n = chars.Length;
            while (i < n)
            {
                var current = chars[i];
                int count = 0;

                //check Duplicates
                while (i < n && chars[i] == current)
                {
                    i++;
                    count++;
                }
                //write 
                chars[index++] = current;
                //
                if (count > 1)
                {
                    foreach (var x in count.ToString())
                    {
                        chars[index++] = x;
                    }
                }


            }
            return index;
        }
    }
}
