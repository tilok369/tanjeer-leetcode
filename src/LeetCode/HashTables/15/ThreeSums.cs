namespace LeetCode.HashTables._15;

public class ThreeSums
{
    public static void Run()
    {
        Console.WriteLine("15. Three Sum:");
        Console.WriteLine(string.Join(" | ", ThreeSums.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join(" | ", ThreeSums.ThreeSum(new int[] { 0, 1, 1 }).Select(i => string.Join(",", i))));
        Console.WriteLine(string.Join(" | ", ThreeSums.ThreeSum(new int[] { 0, 0, 0 }).Select(i => string.Join(",", i))));
    }

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums == null || nums.Length < 3)
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
