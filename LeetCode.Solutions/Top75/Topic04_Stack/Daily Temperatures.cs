namespace LeetCode.Solutions.Top75.Topic04_Stack
{
    internal class Daily_Temperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int size = temperatures.Length;
            int[] res = new int[size];
            var stack = new Stack<int[]>();

            for (int i = 0; i < size; i++)
            {
                while (stack.Count != 0 && stack.Peek()[0] < temperatures[i])
                {
                    var a = stack.Pop();
                    res[a[1]] = i - a[1];
                }
                stack.Push(new int[] { temperatures[i], i });
            }

            return res;
        }
    }
}
