
namespace LeetCode;

public class Arrays
{
    public static int RemoveDuplicates(int[] nums)
    {
        var duplicateCount = 0;
        var len = nums.Length;
        for (int i = 1; i < len; i++)
        {
            if (nums[i - 1] == nums[i])
            {
                duplicateCount++;
                for (int j = i; j < nums.Length - 1; j++)
                {
                    var temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
                i--;
                len--;
            }
        }
        return nums.Length - duplicateCount;

        //faster solution

        //if (nums.Length < 2)
        //{
        //    return nums.Length;
        //}

        //int j = 1;
        //for (int i = 1; i < nums.Length; i++)
        //{
        //    if (nums[i] != nums[i - 1])
        //    {
        //        nums[j++] = nums[i];
        //    }
        //}
        //Array.Resize(ref nums, j);
        //return nums.Length;
    }

    public static int RemoveElement(int[] nums, int val)
    {
        var j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
                nums[j++] = nums[i];
        }

        Console.WriteLine(string.Join(",", nums));
        return j;
    }

    public static int SearchInsert(int[] nums, int target)
    {
        var i = 0;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target)
                return i;
        }

        return i;
    }
}
