namespace LeetCode.Arrays._2765;

public class LongestAlternatingSubarray
{
    public static void Run()
    {
        Console.WriteLine(LongestAlternatingSubarray.AlternatingSubarray(new int[] { 2, 3, 4, 3, 4 }));
    }

    public static int AlternatingSubarray(int[] nums)
    {
        var start = 0;
        var end = 0;
        var max = 0;
        var started = false;
        var threshold = 1;

        for (; end < nums.Length; end++)
        {
            if (nums[end] % 2 == 0 && nums[end] <= threshold && !started)
            {
                start = end;
                started = true;
            }
            else if (started && (nums[end] % 2 != (end - start) % 2 || nums[end] > threshold))
            {
                max = Math.Max(max, end - start);
                started = false;
                if (nums[end] % 2 == 0 && nums[end] <= threshold)
                {
                    start = end;
                    started = true;
                }
            }
        }
        if (started)
            max = Math.Max(max, end - start);

        return max;
    }
}
