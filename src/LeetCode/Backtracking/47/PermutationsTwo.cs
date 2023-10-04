namespace LeetCode.Backtracking._47;

public class PermutationsTwo
{
    public static void Run()
    {
        Console.WriteLine("47. Permutations ||: ");
        Console.WriteLine(string.Join("|", PermutationsTwo.PermuteUnique(new int[] { 1, 1, 2 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join("|", PermutationsTwo.PermuteUnique(new int[] { 2, 2, 1, 1 }).Select(i => string.Join(",", i))));
    }

    public static IList<IList<int>> PermuteUnique(int[] nums)
    {
        var permutations = new Dictionary<string, IList<int>>();
        UniquePermutations(nums.ToList(), 0, permutations);
        return permutations.Select(v => v.Value).ToList();
    }

    private static void UniquePermutations(List<int> nums, int start, Dictionary<string, IList<int>> permutations)
    {
        if (start == nums.Count && !permutations.ContainsKey(String.Join(",", nums)))
            permutations.Add(String.Join(",", nums), new List<int>(nums));

        for (var i = start; i < nums.Count; i++)
        {
            Swap(nums, i, start);
            UniquePermutations(nums, start + 1, permutations);
            Swap(nums, i, start);
        }
    }

    private static void Swap(List<int> nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
