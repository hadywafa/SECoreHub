namespace MicrosoftInterview;

public partial class Solution
{
    public static int MaxProfit(int[] prices)
    {
        //[7,1,5,3,6,4]

        int minPrice = prices[0];
        int maxProfit = 0;
        foreach (var price in prices)
        {
            if (price < minPrice)
                minPrice = price;

            if ((price - minPrice) > maxProfit)
                maxProfit = price - minPrice;
        }

        return maxProfit;
    }
}
