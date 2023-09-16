namespace LeetCode.HashTables._16;

public class ThreeSumsClosest
{
    public static void Run()
    {
        Console.WriteLine("16. 3Sum Closest: ");
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { 0, 0, 0 }, 1));
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { -2, 0, 3, 6, 7 }, 4));
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { 3, 6, 7, -2, 6, 0 }, 4));
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { 0, 3, 6, 7, -2, 6 }, 4));
        Console.WriteLine(ThreeSumsClosest.ThreeSumClosest(new int[] { 4, 0, 5, -5, 3, 3, 0, -4, -5 }, -2));
    }

    public static int ThreeSumClosest(int[] nums, int target)
    {
        //if(nums.Length < 3)
        //    return 0;
        //var closest = int.MaxValue;
        //var sum = 0;
        //Array.Sort(nums);
        //for (int i = 0; i < nums.Length - 2; i++)
        //{
        //    var f = nums[i];
        //    var s = nums[i + 1];
        //    for (int j = i + 2; j < nums.Length; j++)
        //    {
        //        var tempSum = (f + s + nums[j]);
        //        if (Math.Abs(target - tempSum) < closest)
        //        { 
        //            closest = Math.Abs(target - tempSum);
        //            sum = tempSum;
        //        }
        //    }
        //}

        //return sum;

        if (nums == null || nums.Length < 3)
            return int.MaxValue;

        Array.Sort(nums);

        var closest = int.MaxValue;
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var second = i + 1;
            var last = nums.Length - 1;

            while (second < last)
            {
                var tempSum = nums[i] + nums[second] + nums[last];
                var diff = Math.Abs(target - tempSum);
                if (diff < Math.Abs(closest))
                {
                    closest = tempSum - target;
                    sum = tempSum;
                }
                if (tempSum >= target)
                    last--;
                else if (tempSum < target)
                    second++;
            }
        }

        return sum;
    }
}
