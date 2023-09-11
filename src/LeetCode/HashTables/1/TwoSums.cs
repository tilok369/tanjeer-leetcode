namespace LeetCode.HashTables._1;

public class TwoSums
{
    public static void Run()
    {
        Console.WriteLine("1. Two Sum:");
        Console.WriteLine(string.Join(", ", TwoSums.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSum(new int[] { 3, 2, 4 }, 6)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSum(new int[] { 3, 3 }, 6)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSum(new int[] { 1 }, 1)));

        Console.WriteLine(string.Join(", ", TwoSums.TwoSumOptimized(new int[] { 2, 7, 11, 15 }, 9)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSumOptimized(new int[] { 3, 2, 4 }, 6)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSumOptimized(new int[] { 3, 3 }, 6)));
        Console.WriteLine(string.Join(", ", TwoSums.TwoSumOptimized(new int[] { 1 }, 1)));
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
            return new int[] { };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }

        return new int[] { };
    }

    public static int[] TwoSumOptimized(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
            return new int[] { };

        var resultDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var f = nums[i];
            var s = target - nums[i];
            int index;
            if (resultDic.TryGetValue(s, out index))
            {
                return new int[] { index, i };
            }
            if (!resultDic.ContainsKey(f))
                resultDic.Add(f, i);
        }

        return new int[] { };
    }
}
