namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public int StrStr(string haystack, string needle)
        {

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length)
                    return -1;

                int counter = 0;
                var j = 0;
                var k = i;
                if (haystack[i] == needle[j])
                {
                    for (j = 0; j < needle.Length; j++)
                    {
                        if (haystack[k] == needle[j])
                        {
                            k++;
                            counter++;
                        }

                        if (counter == needle.Length)
                            return i;
                    }
                }

            }


            return -1;
        }
    }
}
