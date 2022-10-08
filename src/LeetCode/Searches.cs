
namespace LeetCode;

public class Searches
{
    public static int Search(int[] nums, int target)
    {
        return BinSearch(nums, 0, nums.Length - 1, target);
    }

    private static int BinSearch(int[] nums, int low, int high, int target)
    { 
        if(low > high)
            return -1;

        int mid = (high - low) / 2 + low;

        if(nums[mid] == target)
            return mid;

        if (nums[mid] >= nums[low])
        {
            if (target >= nums[low] && target < nums[mid])
                return BinSearch(nums, low, mid - 1, target);

            return BinSearch(nums, mid + 1, high, target);
        }
        else
        {
            if(target > nums[mid] && target <= nums[high])
                return BinSearch(nums, mid + 1, high, target);

            return BinSearch(nums, low, mid - 1, target);
        }
    }
}
