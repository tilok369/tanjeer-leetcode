namespace LeetCode.DynamicProgramming._70;

public class ClimbingStairs
{
    public static void Run()
    {
        Console.WriteLine("70. Climbing Stairs");
        Console.WriteLine(ClimbingStairs.ClimbStairs(2));
        Console.WriteLine(ClimbingStairs.ClimbStairs(3));
        Console.WriteLine(ClimbingStairs.ClimbStairs(4));
    }

    public static int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            dp[i] = -1;
        }

        return CountWays(n, dp);
    }

    public static int CountWays(int n, int[] dp)
    {
        if (n <= 1)
            return dp[n] = 1;

        if (dp[n] != -1)
        {
            return dp[n];
        }
        dp[n] = CountWays(n - 1, dp) + CountWays(n - 2, dp);
        return dp[n];
    }
}
