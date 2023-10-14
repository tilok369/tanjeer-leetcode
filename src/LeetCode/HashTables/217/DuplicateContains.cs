namespace LeetCode.HashTables._217;

public class DuplicateContains
{
    public static void Run()
    {
        Console.WriteLine("217. Contains Duplicate: ");
        Console.WriteLine(DuplicateContains.ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
        Console.WriteLine(DuplicateContains.ContainsDuplicate(new int[] { 1, 0, 1, 1 }));
        Console.WriteLine(DuplicateContains.ContainsDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }));
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var numDic = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (numDic.ContainsKey(num))
                return true;
            numDic.Add(num, 0);
        }

        return false;
    }
}
