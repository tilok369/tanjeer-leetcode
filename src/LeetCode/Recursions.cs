
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

    

    

    public static IList<IList<int>> Permute(int[] nums)
    {
        var permutations = new List<IList<int>>();
        Permutations(nums.ToList(), new List<int>(), permutations);
        return permutations;
    }

    private static void Permutations(List<int> choices, List<int> workingSet, List<IList<int>> permutations)
    {
        if(choices.Count == 0)
            permutations.Add(new List<int>(workingSet));

        for (var i = 0; i < choices.Count; i++)
        {
            var item = choices[i];
            choices.RemoveAt(i);
            workingSet.Add(item);
            Permutations(choices, workingSet, permutations);

            choices.Insert(i, item);
            workingSet.Remove(item);

        }
    }

    public static IList<IList<int>> PermuteUnique(int[] nums)
    {
        var permutations = new Dictionary<string, IList<int>>();
        UniquePermutations(nums.ToList(), 0, permutations);
        return permutations.Select(v=>v.Value).ToList();
    }

    private static void UniquePermutations(List<int> nums, int start, Dictionary<string, IList<int>> permutations)
    {
        if(start == nums.Count && !permutations.ContainsKey(String.Join(",", nums)))
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
