namespace LeetCode.Maths._29;

public class DivideTwoIntegers
{
    public static void Run()
    {
        Console.WriteLine("29. Divide Two Integers: ");
        Console.WriteLine(DivideTwoIntegers.Divide(43, 3));
        Console.WriteLine(DivideTwoIntegers.Divide(7, -3));
        Console.WriteLine(DivideTwoIntegers.Divide(33, 2));
    }

    
    public static int Divide(int dividend, int divisor)
    {
        if (divisor == 0) return int.MaxValue;
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
}
