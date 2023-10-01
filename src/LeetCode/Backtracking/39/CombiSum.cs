namespace LeetCode.Backtracking._39;

public class CombiSum
{
    public static void Run()
    {
        Console.WriteLine("Combination Sum: ");
        Console.WriteLine(string.Join("|", CombiSum.CombinationSum(new int[] { 2, 3, 6, 7 }, 7)
            .Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", CombiSum.CombinationSum(new int[] { 2, 3, 5 }, 8)
            .Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", CombiSum.CombinationSum(new int[] { 2 }, 1)
            .Select(i => string.Join(",", i))));

        Console.WriteLine("Combination Sum ||: ");
        Console.WriteLine(string.Join("|", CombiSum.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8)
            .Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", CombiSum.CombinationSum2(new int[] { 2, 5, 2, 1, 2 }, 5)
            .Select(i => string.Join(",", i))));
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
