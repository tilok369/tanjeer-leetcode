using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Maths._268;

public class MissingNumber
{
    public static void Run()
    {
        Console.WriteLine("268, Missing Number: ");
        Console.WriteLine(FindMissingNumberXor(new[] { 3, 0, 1 }));
        Console.WriteLine(FindMissingNumberMath(new[] { 3, 0, 1 }));
    }

    private static int FindMissingNumberXor(int[] nums)
    {
        int xor = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            xor ^= i;
            xor ^= nums[i];
        }

        return xor;
    }

    private static int FindMissingNumberMath(int[] nums)
    {
        int n = nums.Length;
        int expected = n * (n + 1) / 2;
        int actual = nums.Sum();
        return expected - actual;
    }
}
