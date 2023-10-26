namespace LeetCode.DynamicProgramming._55;

public class JumpGame
{
    public static void Run()
    {
        Console.WriteLine("55. Jump Game: ");
        var nums1 = new int[] { 2, 3, 1, 1, 4 };
        var nums2 = new int[] { 3, 2, 1, 0, 4 };

        Console.WriteLine(JumpGame.CanJump(nums1));
        Console.WriteLine(JumpGame.CanJump(nums2));
    }

    public static bool CanJump(int[] nums)
    {
        var maxJump = nums[0];
        var i = 0;
        for (; i <= maxJump; i++)
        {
            if (i >= nums.Length - 1) return true;
            maxJump = Math.Max(maxJump, nums[i] + i);
        }

        return false;
    }
}
