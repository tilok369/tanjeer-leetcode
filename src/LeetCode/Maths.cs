
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

    public static string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";
        var multiplyList = new List<List<int>>();
        var zeros = new List<int>();
        for (var i = num1.Length - 1; i >= 0; i--)
        {
            var list = new List<int>();
            list.AddRange(new List<int>(zeros));
            var carry = 0;
            for (var j = num2.Length - 1; j >= 0; j--)
            {
                var n1 = (int)num1[i] - 48;
                var n2 = (int)num2[j] - 48;
                list.Add(carry + (n1 * n2) % 10);
                carry = (n1 * n2) / 10;
            }
            if(carry > 0)
                list.Add(carry);
            multiplyList.Add(list);
            zeros.Add(0);
        }

        var max = multiplyList.Select(x => x.Count).Max();
        var result = new List<string>();
        var carry2 = 0;
        for (var k = 0; k < max; k++)
        {
            var sum = multiplyList.Sum(x => k <= x.Count - 1 ? x[k] : 0);
            result.Add(((carry2 + sum) % 10) + "");
            carry2= (carry2 + sum) / 10;
        }
        if (carry2 > 0)
            result.Add(carry2 + "");

        result.Reverse();
        return string.Join("", result);
    }

    public static double MyPow(double x, int n)
    {
        if (n == 0)
            return 1.0;
        if (x == 0)
            return 0.0;
        var modN = Math.Abs(n);
        var index = 1;
        var result = 1.0;
        while (index <= modN)
        { 
            result *= x;
            index++;
        }

        return n < 0 ? 1 / result : result;
    }

    public static double MyPowOpt(double x, int n)
    {
        if (n == 0)
            return 1.0;
        if (x == 0)
            return 0.0;
        var modN = Math.Abs((long)n);

        var result = 1.0;
        while (modN > 0)
        {
            if ((modN & 1) != 0)
            {
                result *= x;
            }

            modN >>= 1;
            x *= x;

        }

        return n < 0 ? 1 / result : result;
    }

    public static double MyPowOpt2(double x, int n)
    {
        if (n == 0)
            return 1.0;
        if (x == 0)
            return 0.0;
        var modN = Math.Abs((long)n);

        var result = 1.0;
        while (modN > 0)
        {
            if (modN % 2 == 1)
            {
                result += x;
                modN -= 1;
            }
            else 
            {
                x *= x;
                modN /= 2;
            }

        }

        return n < 0 ? 1 / result : result;
    }
}
