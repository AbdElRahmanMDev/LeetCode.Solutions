namespace LeetCode.Solutions.Top150.Topic04_Stack
{
    internal class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dict =
            new Dictionary<char, char>{
                {')','('},
                {']','['},
                {'}','{'}
            };
            //"]["
            Stack<char> stack = new Stack<char>();
            foreach (var a in s)
            {
                if (dict.ContainsKey(a))
                {
                    var res = dict[a];
                    if (stack.Count != 0 && res == stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(a);
                }
            }

            return stack.Count == 0;

        }
    }
}
