namespace LeetCode.SlidingWindow._209;

public class MinSubArraySum
{
    public static void Run()
    {
        Console.WriteLine("209. Minimum Size Subarray Sum: ");
        Console.WriteLine(MinSubArraySum.MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen(4, new int[] { 1, 4, 4 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen(11, new int[] { 1, 2, 3, 4, 5 }));

        Console.WriteLine(MinSubArraySum.MinSubArrayLen2(7, new int[] { 2, 3, 1, 2, 4, 3 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen2(4, new int[] { 1, 4, 4 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen2(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
        Console.WriteLine(MinSubArraySum.MinSubArrayLen2(11, new int[] { 1, 2, 3, 4, 5 }));
    }

    public static int MinSubArrayLen(int target, int[] nums)
    {
        var sum = 0;
        var len = int.MaxValue;
        var size = 0;
        var index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            size++;
            if (sum >= target)
            {
                len = Math.Min(len, size);
                size = 0;
                sum = 0;
                i = index++;
            }
        }

        return len == int.MaxValue ? 0 : len;
    }

    public static int MinSubArrayLen2(int target, int[] nums)
    {
        var sum = 0;
        var len = int.MaxValue;
        var start = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= target)
            {
                len = Math.Min(len, i - start + 1);
                sum -= nums[start++];
            }
        }

        return len == int.MaxValue ? 0 : len;
    }
}
