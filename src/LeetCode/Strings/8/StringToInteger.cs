namespace LeetCode.Strings._8;

public class StringToInteger
{
    public static void Run()
    {
        Console.WriteLine("AtoI: ");
        Console.WriteLine(StringToInteger.MyAtoi("42"));
        Console.WriteLine(StringToInteger.MyAtoi("   -42"));
        Console.WriteLine(StringToInteger.MyAtoi("4193 with words"));
        Console.WriteLine(StringToInteger.MyAtoi("12345678900"));
        Console.WriteLine(StringToInteger.MyAtoi("-12345678900"));
        Console.WriteLine(StringToInteger.MyAtoi("-+12"));
        Console.WriteLine(StringToInteger.MyAtoi("+-12"));
        Console.WriteLine(StringToInteger.MyAtoi("0012"));
        Console.WriteLine(StringToInteger.MyAtoi(""));
        Console.WriteLine(StringToInteger.MyAtoi(" "));
        Console.WriteLine(StringToInteger.MyAtoi("9223372036854775808"));
    }

    public static int MyAtoi(string s)
    {
        var sign = 1;
        long integer = 0;
        var i = 0;
        for (; i < s.Length; i++)
        {
            if (s[i] != ' ') break;
        }
        if (i < s.Length && (s[i] == '-' || s[i] == '+'))
        {
            if (s[i] == '-')
                sign = -1;
            i++;
        }

        for (; i < s.Length; i++)
        {
            if (s[i] < 48 || s[i] > 57)
                break;
            if (integer > int.MaxValue)
                break;
            integer = (integer * 10) + (s[i] - 48);
        }

        integer = integer * sign;

        return integer < int.MinValue
            ? int.MinValue
            : integer > int.MaxValue
                ? int.MaxValue : int.Parse(integer.ToString());
    }
}
