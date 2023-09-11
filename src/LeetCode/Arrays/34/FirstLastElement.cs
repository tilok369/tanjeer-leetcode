namespace LeetCode.Arrays._34;

public class FirstLastElement
{
    public static void Run()
    {
        var nums1 = new int[] { 5, 7, 7, 8, 8, 10 };
        var nums2 = new int[] {  };
        Console.WriteLine(string.Join(",", FirstLastElement.SearchRange(nums1, 8)));
        Console.WriteLine(string.Join(",", FirstLastElement.SearchRange(nums1, 6)));
        Console.WriteLine(string.Join(",", FirstLastElement.SearchRange(nums2, 0)));
    }

    public static int[] SearchRange(int[] nums, int target)
    {
        var firstLast = new int[] { -1, -1 };

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != target)
                continue;
            if(firstLast[0] == -1)
                firstLast[0] = i;
            firstLast[1] = i;
        }

        return firstLast;
    }
}
