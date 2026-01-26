namespace LeetCode.Solutions.Top75.Topic04_Stack
{
    internal class Online_Stock_Span
    {
        Stack<int[]> stack;
        public Online_Stock_Span()
        {
            stack = new Stack<int[]>();

        }

        public int Next(int price)
        {
            int currentspan = 1;
            while (stack.Count > 0 && stack.Peek()[0] <= price)
            {
                var prev = stack.Pop();
                currentspan += prev[1];
            }
            stack.Push(new int[] { price, currentspan });
            return currentspan;
        }
    }
}
