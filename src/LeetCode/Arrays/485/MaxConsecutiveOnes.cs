namespace LeetCode.Arrays._485;

public class MaxConsecutiveOnes
{
    public static void Run()
    {
        Console.WriteLine("485. Maximum consecutive one’s: ");
        Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1 }));
        Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 0, 0 }));
    }

    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        var count = 0;
        var len = 0;
        foreach (var x in nums)
        {
            if (x == 1)
            {
                count++;
            }
            else
            {
                len = Math.Max(len, count);
                count = 0;
            }
        }
        len = Math.Max(len, count);

        return len;
    }
}
