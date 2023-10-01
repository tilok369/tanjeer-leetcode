using System.Text;

namespace LeetCode.Recursion._38;

public class CountSay
{
    public static void Run()
    {
        Console.WriteLine("38. Count And Say: ");
        Console.WriteLine(CountSay.CountAndSay(1));
        Console.WriteLine(CountSay.CountAndSay(2));
        Console.WriteLine(CountSay.CountAndSay(3));
        Console.WriteLine(CountSay.CountAndSay(4));
        Console.WriteLine(CountSay.CountAndSay(5));
        Console.WriteLine(CountSay.CountAndSay(6));
    }

    public static string CountAndSay(int n)
    {
        if (n == 1) return "1";

        var str = CountAndSay(n - 1);

        return CalculateNext(str);
    }

    private static string CalculateNext(string str)
    {
        var result = new StringBuilder();
        var pre = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != str[pre])
            {
                result.Append(i - pre).Append(str[pre]);
                pre = i;
            }
        }

        result.Append(str.Length - pre).Append(str[pre]);

        return result.ToString();
    }
}
