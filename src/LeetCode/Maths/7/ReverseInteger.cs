namespace LeetCode.Maths._7;

public class ReverseInteger
{
    public static void Run()
    {
        Console.WriteLine("7. Reverse Integer:");
        Console.WriteLine(ReverseInteger.Reverse(123));
        Console.WriteLine(ReverseInteger.Reverse(-123));
        Console.WriteLine(ReverseInteger.Reverse(120));
        Console.WriteLine(ReverseInteger.Reverse(11234456));
        Console.WriteLine(ReverseInteger.Reverse(1534236469));
    }

    public static int Reverse(int x)
    {

        var digits = new Dictionary<long, long>();
        var place = 1;
        var y = x * (x < 0 ? -1 : 1);
        while (y > 0)
        {
            var div = y / 10;
            var rem = y % 10;
            y = div;
            digits.Add(place, rem);
            if (y > 0) place *= 10;
        }

        long reverse = 0;
        foreach (var digit in digits)
        {
            reverse += (digit.Value * (place / digit.Key));
        }

        return reverse < int.MinValue || reverse > int.MaxValue ? 0 : (int)reverse * (x < 0 ? -1 : 1);
    }
}
