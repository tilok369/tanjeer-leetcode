namespace LeetCode.Arrays._35;

public class SearchInsertPosition
{
    public static void Run()
    {
        Console.WriteLine("35. Search Insert Position: ");
        Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
        Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
        Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
        Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 2, 3, 5, 6 }, 1));
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
