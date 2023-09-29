namespace LeetCode.Arrays._27;

public class RemoveArrayElement
{
    public static void Run()
    {
        Console.WriteLine("Remove Duplicates from Sorted Array: ");
        Console.WriteLine(RemoveArrayElement.RemoveElement(new[] { 3, 2, 2, 3 }, 3));
        Console.WriteLine(RemoveArrayElement.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
        Console.WriteLine(RemoveArrayElement.RemoveElement(new[] { 2, 2, 2 }, 2));
        Console.WriteLine(RemoveArrayElement.RemoveElement(new[] { 0, 1, 1, 6, 3, 0, 4, 5 }, 2));
    }

    public static int RemoveElement(int[] nums, int val)
    {
        var j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[j++] = nums[i];
        }

        Console.WriteLine(string.Join(",", nums));
        return j;
    }
}
