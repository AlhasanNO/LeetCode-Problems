﻿public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (min > prices[i])
                min = prices[i];

            else if (profit < (prices[i] - min))
                profit = prices[i] - min;
        }

        return profit;
    }
}