
namespace LeetCode;

public class Mathss
{
    
    

    

    

    

    

    public static bool IsUgly(int n)
    {
        for (long i = 2; i <= Math.Abs((long)n/2); i++)
        {
            if(n%i==0 && i > 5 && (IsPrime(i)))
                return false;

        }
        return true;
    }

    public static bool IsPrime(long n)
    {
        for (long i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static bool IsUglyOpt(int n)
    {
        if(n <= 0) return false;

        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n == 1;
    }

    public static int NthUglyNumber(int n)
    {
        var uglyNumbers = new List<int>();
        uglyNumbers.Add(1);
        int i2=0, i3=0, i5 = 0;

        var count = 0;
        while (count < n - 1)
        {
            var n2 = uglyNumbers[i2] * 2;
            var n3 = uglyNumbers[i3] * 3;
            var n5 = uglyNumbers[i5] * 5;
            var min = Math.Min(n2, Math.Min(n3, n5));
            uglyNumbers.Add(min);
            if (min == n2) i2++;
            if (min == n3) i3++;
            if (min == n5) i5++;
            count++;
        }

        return uglyNumbers.Last();
    }
}
