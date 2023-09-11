namespace LeetCode.Matrix._1672;

public class RichestCustomerWealth
{
    public static void Run()
    {
        var accounts1 = new int[][] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } };
        var accounts2 = new int[][] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } };

        Console.WriteLine("1672. Richest Customer Wealth:");
        Console.WriteLine(RichestCustomerWealth.MaximumWealth(accounts1));
        Console.WriteLine(RichestCustomerWealth.MaximumWealth(accounts2));
    }

    public static int MaximumWealth(int[][] accounts)
    {
        var maxWeath = 0;
        for (var i = 0; i < accounts.Length; i++)
        {
            var totalWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                totalWealth += accounts[i][j];
            }
            maxWeath = totalWealth > maxWeath ? totalWealth : maxWeath;
        }
        return maxWeath;
    }
}
