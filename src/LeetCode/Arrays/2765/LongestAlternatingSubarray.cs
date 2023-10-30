namespace LeetCode.Arrays._2765;

public class LongestAlternatingSubarray
{
    public static void Run()
    {
        Console.WriteLine(LongestAlternatingSubarray.AlternatingSubarray(new int[] { 2, 3, 4, 3, 4 }));
        Console.WriteLine(LongestAlternatingSubarray.AlternatingSubarray(new int[] { 4, 5, 6 }));
    }

    public static int AlternatingSubarray(int[] nums)
    {
        var len = nums.Length;
        if (len == 1)
            return -1;

        var size = 0;

        for (var i = 0; i < len; i++)
        { 
            var prev = nums[i];
            var diff = 1;
            var tempSize = 0;
            for (int j = i + 1; j < len; j++)
            {
                if (nums[j] - prev == diff)
                {
                    tempSize = j - i + 1;
                    prev = nums[j];
                    diff *= -1;
                }
                else
                    break;
            }
            size = Math.Max(size, tempSize);
        }

        return size == 0 ? -1 : size;
    }
}
