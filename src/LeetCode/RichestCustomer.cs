
namespace LeetCode;

public class RichestCustomer
{
    public static int MaximumWealth(int[][] accounts)
    {
        var maxWeath = 0;
        for (var i = 0; i < accounts.Length; i++)
        {
            var totalWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                totalWealth+=accounts[i][j];
            }
            maxWeath = totalWealth > maxWeath ? totalWealth : maxWeath;
        }
        return maxWeath;
    }
}
