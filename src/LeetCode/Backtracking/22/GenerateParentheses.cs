namespace LeetCode.Backtracking._22;

public class GenerateParentheses
{
    public static void Run()
    {
        Console.WriteLine("Generate Parentheses: ");
        Console.WriteLine("3: " + string.Join(",", GenerateParentheses.GenerateParenthesis(3)));
        Console.WriteLine("1: " + string.Join(",", GenerateParentheses.GenerateParenthesis(1)));
        Console.WriteLine("4: " + string.Join(",", GenerateParentheses.GenerateParenthesis(4)));
    }

    public static IList<string> GenerateParenthesis(int n)
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
