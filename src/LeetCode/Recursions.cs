
using System.Text;

namespace LeetCode;

public class Recursions
{
    //private static List<string> strlist = new List<string>();
    public static List<string> GenerateParenthesis(int n)
    {
        var paranthesesList = new List<string>();
        Backtracker(paranthesesList, n, n, string.Empty);
        return paranthesesList;
    }


    private static void Backtracker(List<string> paranthesesList, int left, int right, string result)
    {
        if (left == 0 && right == 0)
        {
            paranthesesList.Add(result);
            return;
        }

        if (left > 0)
        {
            Backtracker(paranthesesList, left - 1, right, result + '(');
        }

        if (right > left)
        {
            Backtracker(paranthesesList, left, right - 1, result + ')');
        }
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
