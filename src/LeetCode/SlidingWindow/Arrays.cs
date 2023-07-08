
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
            if (nums[i] != val)
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

    public static int Jump(int[] nums)
    {
        if (nums.Length <= 1 || nums[0] == 0)
            return 0;
        if (nums[0] >= nums.Length - 1)
            return 1;
        var steps = 0;
        var n = 0;
        var current = nums[0];
        while (n < nums.Length - 1)
        {
            var max = 0;
            var nexJump = 1;
            for (var i = 1; i <= current; i++)
            {
                if (n + i >= nums.Length - 1)
                {
                    nexJump = nums.Length;
                    break;
                }
                if (nums[n + i] >= max)
                {
                    max = nums[n + i];
                    nexJump = i;
                }
            }
            steps++;
            n += nexJump;
            if (n < nums.Length)
                current = nums[n];
            if (current == 0)
                return 0;
        }

        return steps;
    }

    public static int Jump2(int[] nums)
    {
        if (nums.Length <= 1 || nums[0] == 0)
            return 0;

        var jumps = 0;
        var max = nums[0];
        var nextMax = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (max >= nums.Length - 1)
            {
                jumps++;
                return jumps;
            }

            nextMax = Math.Max(i + nums[i], nextMax);

            if (i == max)
            {
                max = nextMax;
                jumps++;
            }
        }

        return jumps;
    }

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

    public static int MaxConsecutiveOnes(int[] nums)
    {
        var count = 0;
        var len = 0;
        foreach (var x in nums)
        {
            if (x == 1)
            {
                count++;
            }
            else
            {
                len = Math.Max(len, count);
                count = 0;
            }
        }
        len = Math.Max(len, count);

        return len;
    }

    public static int CountSubstring(string s)
    {
        // To store the total count
        // of substrings
        int ans = 0;

        int i = 0;

        var n = s.Length;

        // Traversing the string
        while (i < n)
        {

            // Count of consecutive
            // 0's & 1's
            int cnt0 = 0, cnt1 = 0;

            // Counting subarrays of
            // type "01"
            if (s[i] == '0')
            {

                // Count the consecutive
                // 0's
                while (i < n && s[i] == '0')
                {
                    cnt0++;
                    i++;
                }

                // If consecutive 0's
                // ends then check for
                // consecutive 1's
                int j = i;

                // Counting consecutive 1's
                while (j < n && s[j] == '1')
                {
                    cnt1++;
                    j++;
                }
            }

            // Counting subarrays of
            // type "10"
            else
            {

                // Count consecutive 1's
                while (i < n && s[i] == '1')
                {
                    cnt1++;
                    i++;
                }

                // If consecutive 1's
                // ends then check for
                // consecutive 0's
                int j = i;

                // Count consecutive 0's
                while (j < n && s[j] == '0')
                {
                    cnt0++;
                    j++;
                }
            }

            // Update the total count
            // of substrings with
            // minimum of (cnt0, cnt1)
            ans += Math.Min(cnt0, cnt1);
        }

        // Return answer
        return ans;
    }
}
