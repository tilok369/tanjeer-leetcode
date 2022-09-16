
namespace LeetCode;

public class Summation
{
    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
            return new int[] { };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                    return new int[]{i, j};
            }
        }

        return new int[]{};
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
            if(!resultDic.ContainsKey(f))
                resultDic.Add(f, i);
        }

        return new int[] { };
    }

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        if(nums == null || nums.Length < 3)
            return new List<IList<int>>();

        var target = 0;
        var triplets = new List<IList<int>>();
        HashSet<string> visited = new HashSet<string>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            var newTarget = target - nums[i];
            var start = i + 1;
            var end = nums.Length - 1;

            while (start < end)
            {
                var sum = nums[start] + nums[end];
                if (sum < newTarget)
                { 
                    start++;
                    continue;
                }
                if (sum > newTarget)
                {
                    end--;
                    continue;
                }

                var triplet = new List<int> { nums[i], nums[start], nums[end] };
                if (!visited.Contains(string.Join(",", triplet)))
                {
                    triplets.Add(triplet);
                    visited.Add(string.Join(",", triplet));
                }

                start++;
                end--;
            }
        }

        return triplets;
    }
}
