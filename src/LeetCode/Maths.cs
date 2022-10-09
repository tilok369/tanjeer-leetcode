
namespace LeetCode;

public class Maths
{
    
    public static int Divide(int dividend, int divisor)
    {
        if(divisor == 0) return int.MaxValue;
        var sign = !((dividend > 0) ^ (divisor > 0));

        long dividendLng = Math.Abs((long)dividend);
        long divisorLng = Math.Abs((long)divisor);

        long result = 0;
        while (dividendLng >= divisorLng)
        {
            long cur = 1;
            long start = divisorLng;
            while ((start << 1) <= dividendLng)
            {
                start <<= 1;
                cur <<= 1;
            }
            dividendLng -= start;
            result += cur;
        }

        return !sign
            ? (-result < int.MinValue ? int.MinValue : (int)-result)
            : (result > int.MaxValue ? int.MaxValue : (int)result);
    }

    /// <summary>
    /// Algo: step#1 = from right to left find the first digit (partition number) which violates the increase trend
    /// step#2 = From right to left, find the first digit which is greater than the partition number
    /// step#3 = swap partition number and change number
    /// step#4 = reverse the numbers after partition index
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int[] NextPermutation(int[] nums)
    {
        var partitionIndex = nums.Length - 2;

        while (partitionIndex >= 0)
        {
            if (nums[partitionIndex] < nums[partitionIndex + 1])
                break;
            partitionIndex--;
        }

        if (partitionIndex >= 0)
        {
            var changeNumberIndex = nums.Length - 1;

            while (changeNumberIndex > partitionIndex)
            {
                if (nums[changeNumberIndex] > nums[partitionIndex])
                    break;
                changeNumberIndex--;
            }

            Swap(ref nums[partitionIndex], ref nums[changeNumberIndex]);
        }

        Reverse(nums, partitionIndex + 1);

        return nums;
    }

    private static void Reverse(int[] nums, int index)
    {
        for (int start = index, end = nums.Length - 1; start < end; start++, end--)
        { 
            Swap(ref nums[start], ref nums[end]);
        }
    }

    private static void Swap(ref int num1, ref int num2)
    {
        var temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
