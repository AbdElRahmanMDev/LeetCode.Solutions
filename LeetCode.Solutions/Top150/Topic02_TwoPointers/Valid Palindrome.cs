
namespace LeetCode.Solutions.Top150.Topic02_TwoPointers;

internal class Valid_Palindrome
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (!Check(s[i]))
            {
                i++;
                continue;
            }
            if (!Check(s[j]))
            {
                j--;
                continue;
            }

            if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                return false;

            i++;
            j--;
        }
        return true;
    }


    public bool Check(char c)
    {
        return Char.IsLetterOrDigit(c);
    }
}
