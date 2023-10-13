namespace LeetCode.Maths._263;

public class UglyNumber
{
    public static void Run()
    {
        Console.WriteLine("263. Ugly Number: ");
        Console.WriteLine(UglyNumber.IsUglyOpt(6));
        Console.WriteLine(UglyNumber.IsUglyOpt(1));
        Console.WriteLine(UglyNumber.IsUglyOpt(14));
        Console.WriteLine(UglyNumber.IsUglyOpt(23));
        Console.WriteLine(UglyNumber.IsUglyOpt(16));
        Console.WriteLine(UglyNumber.IsUglyOpt(17));
        Console.WriteLine(UglyNumber.IsUglyOpt(-2147483648));
    }

    public static bool IsUgly(int n)
    {
        for (long i = 2; i <= Math.Abs((long)n / 2); i++)
        {
            if (n % i == 0 && i > 5 && (IsPrime(i)))
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
        if (n <= 0) return false;

        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n == 1;
    }
}
