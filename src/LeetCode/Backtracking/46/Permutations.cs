namespace LeetCode.Backtracking._46;

public class Permutations
{
    public static void Run()
    {
        Console.WriteLine("46. Permutations: ");
        Console.WriteLine(string.Join("|", Permutations.Permute(new int[] { 1, 2, 3 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", Permutations.Permute(new int[] { 0, 1 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", Permutations.Permute(new int[] { 1 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", Permutations.Permute(new int[] { 2, 2, 1, 1 }).Select(i => string.Join(",", i))));
    }

    public static IList<IList<int>> Permute(int[] nums)
    {
        var permutations = new List<IList<int>>();
        Permutation(nums.ToList(), new List<int>(), permutations);
        return permutations;
    }

    private static void Permutation(List<int> choices, List<int> workingSet, List<IList<int>> permutations)
    {
        if (choices.Count == 0)
            permutations.Add(new List<int>(workingSet));

        for (var i = 0; i < choices.Count; i++)
        {
            var item = choices[i];
            choices.RemoveAt(i);
            workingSet.Add(item);
            Permutation(choices, workingSet, permutations);

            choices.Insert(i, item);
            workingSet.Remove(item);

        }
    }
}
