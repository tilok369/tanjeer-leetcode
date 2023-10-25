namespace LeetCode.SlidingWindow._1984;

public class MinDifferenceOfKScores
{
    public static void Run()
    {
        Console.WriteLine("1984. Minimum Difference Between Highest and Lowest of K Scores: ");
        Console.WriteLine(MinDifferenceOfKScores.MinimumDifference(new int[] { 90 }, 1));
        Console.WriteLine(MinDifferenceOfKScores.MinimumDifference(new int[] { 9, 4, 1, 7 }, 2));
    }

    public static int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);

        int min = int.MaxValue;
        for (int i = 0; i <= nums.Length - k; i++)
        {
            var diff = nums[i + k - 1] - nums[i];
            min = Math.Min(min, diff);
        }

        return min;
    }
}
