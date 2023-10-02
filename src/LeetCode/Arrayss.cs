
namespace LeetCode;

public class Arrayss
{
    

    

    

    

    public bool CanJump(int[] nums)
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

    public static int MaxConsecutiveOnes(int[] nums)
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
