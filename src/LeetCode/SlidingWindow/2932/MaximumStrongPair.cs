using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow._2932;

public class MaximumStrongPair
{
    public static void Run()
    {
        Console.WriteLine("2932. Maximum Strong Pair XOR I: ");
        Console.WriteLine(MaximumStrongPairXor(new[] { 1, 2, 3, 4, 5} ));
        Console.WriteLine(MaximumStrongPairXor(new[] { 10, 100} ));
        Console.WriteLine(MaximumStrongPairXor(new[] { 5, 6, 25, 30} ));
    }

    private static int MaximumStrongPairXor(int[] nums)
    {
        int maxXor = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                int x = nums[i];
                int y = nums[j];

                if (Math.Abs(x - y) <= Math.Min(x, y))
                {
                    maxXor = Math.Max(maxXor, x ^ y);
                }
            }
        }

        return maxXor;
    }
}
