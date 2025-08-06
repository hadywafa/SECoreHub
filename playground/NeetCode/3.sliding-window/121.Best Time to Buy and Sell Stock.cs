namespace NeetCode.SlidingWindow;

public class P121
{
    public static void Run()
    {
        int[] prices = [7, 1, 5, 3, 6, 4];
        var result = MaxProfit_1(prices);
        System.Console.WriteLine(result);
    }

    public static int MaxProfit_1(int[] prices)
    {
        //[7,1,5,3,6,4]
        int maxProfit = 0;
        int l = 0;
        int r = 1;
        while (r < prices.Length)
        {
            maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
            if (prices[l] > prices[r])
            {
                l = r;
                r++;
            }
            else
                r++;
        }
        return maxProfit;
    }

    public static int MaxProfit_2(int[] prices)
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
