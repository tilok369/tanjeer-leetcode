namespace LeetCode.SlidingWindow._219;

public class NearbyDuplicate
{
    public static void Run()
    {
        Console.WriteLine("219. Contains Duplicate II: ");
        Console.WriteLine(NearbyDuplicate.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
        Console.WriteLine(NearbyDuplicate.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
        Console.WriteLine(NearbyDuplicate.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numDic.ContainsKey(nums[i]))
            {
                if (i - numDic[nums[i]] <= k)
                    return true;
                else
                    numDic[nums[i]] = i;
            }
            else
                numDic.Add(nums[i], i);
        }
        return false;
    }
}
