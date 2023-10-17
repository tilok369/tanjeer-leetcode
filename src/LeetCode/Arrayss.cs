
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

    
}
