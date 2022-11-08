
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

    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<IList<int>>();
        RecurseCombSum(candidates, target, new List<int>(), result, 0);
        return result;
    }

    private static void RecurseCombSum(int[] candidates, int target, List<int> combination, 
        List<IList<int>> result, int index)
    {
        if (target < 0) return;
        if (target == 0 && !result.Contains(combination))
        { 
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = index; i < candidates.Length && candidates[i] <= target; i++)
        {
            var item = candidates[i];
            combination.Add(item);
            RecurseCombSum(candidates, target - item, combination, result, i);
            combination.RemoveAt(combination.Count - 1);
        }
    }

    public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<IList<int>>();
        RecurseCombSum2(candidates, target, new List<int>(), result, 0);
        return result;
    }

    private static void RecurseCombSum2(int[] candidates, int target, List<int> combination,
        List<IList<int>> result, int index)
    {
        if (target < 0) return;
        if (target == 0 && !result.Contains(combination))
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = index; i < candidates.Length && candidates[i] <= target; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1])
                continue;
            var item = candidates[i];
            combination.Add(item);
            RecurseCombSum2(candidates, target - item, combination, result, i + 1);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
