namespace LeetCode.Solutions.Top75.Topic04_Stack
{
    internal class Removing_Stars_From_a_String
    {
        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c != '*')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            return new string(stack.Reverse().ToArray());
        }
    }
}
