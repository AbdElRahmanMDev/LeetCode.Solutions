namespace LeetCode.Solutions.Top150.Topic01_Array
{
    internal class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {

            int maxProfit = 0;
            int buy = 0;
            int sell = 1;
            while (sell < prices.Length)
            {
                if (prices[sell] > prices[buy])
                {
                    maxProfit = Math.Max(maxProfit, prices[sell] - prices[buy]);
                }
                else
                {
                    buy = sell;
                }
                sell++;
            }

            return maxProfit;
        }
    }
}
