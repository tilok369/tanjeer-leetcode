namespace LeetCode.Maths._50;

public class Pow
{
    public static void Run()
    {
        Console.WriteLine("50. Pow(x, n): ");
        // Console.WriteLine(Pow.MyPow(2.0000, 10));
        // Console.WriteLine(Pow.MyPow(2.1000, 3));
        // Console.WriteLine(Pow.MyPow(2.0000, -2));
        //Console.WriteLine(Pow.MyPowOpt(2.0000, 10));
        Console.WriteLine(Pow.MyPowOpt(2.1000, 3));
        //Console.WriteLine(Pow.MyPowOpt(2.0000, -2));
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
