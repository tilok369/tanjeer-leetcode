namespace LeetCode.Arrays._26;

public class RemoveArrayDuplicates
{
    public static void Run()
    {
        Console.WriteLine("Remove Duplicates from Sorted Array: ");
        Console.WriteLine(RemoveArrayDuplicates.RemoveDuplicates(new[] { 1, 1, 2 }));
        Console.WriteLine(RemoveArrayDuplicates.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 })); 
        Console.WriteLine(RemoveArrayDuplicates.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 4, 4, 4, 4, 5 }));
    }

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
}
