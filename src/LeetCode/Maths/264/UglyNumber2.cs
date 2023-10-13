namespace LeetCode.Maths._264;

public class UglyNumber2
{
    public static void Run()
    {
        Console.WriteLine("264. Ugly Number ||: ");
        Console.WriteLine(UglyNumber2.NthUglyNumber(10));
    }

    public static int NthUglyNumber(int n)
    {
        var uglyNumbers = new List<int>();
        uglyNumbers.Add(1);
        int i2 = 0, i3 = 0, i5 = 0;

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
