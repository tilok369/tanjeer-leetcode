
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
}
