namespace LeetCode.HashTables._18;

public class FourSums
{
    public static void Run()
    {
        Console.WriteLine("18. 4sum: ");
        Console.WriteLine(string.Join("|", FourSums.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0).Select(s => string.Join(",", s))));
        Console.WriteLine(string.Join("|", FourSums.FourSum(new int[] { 2, 2, 2, 2, 2 }, 8).Select(s => string.Join(",", s))));
        Console.WriteLine(string.Join("|", FourSums.FourSum(new int[] { 2, 2, 2, 2, 2 }, 5).Select(s => string.Join(",", s))));
        Console.WriteLine(string.Join("|", FourSums.FourSum(new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296).Select(s => string.Join(",", s))));
    }

    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        var quadruplets = new List<IList<int>>();
        if (nums.Length < 4) return quadruplets;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                var first = j + 1;
                var last = nums.Length - 1;

                while (first < last)
                {
                    if (first > j + 1 && nums[first] == nums[first - 1])
                    {
                        first++;
                        continue;
                    }
                    if (last < nums.Length - 1 && nums[last] == nums[last + 1])
                    {
                        last--;
                        continue;
                    }

                    var sum = (long)nums[i] + (long)nums[j] + (long)nums[first] + (long)nums[last];
                    if (sum > target) last--;
                    else if (sum < target) first++;
                    else
                    {
                        quadruplets.Add(new List<int> { nums[i], nums[j], nums[first], nums[last] });
                        first++;
                        last--;
                    }
                }
            }
        }

        return quadruplets;
    }
}