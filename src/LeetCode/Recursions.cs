
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

    

    

    

    
}
