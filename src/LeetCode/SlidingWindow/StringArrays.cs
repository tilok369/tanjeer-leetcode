
namespace LeetCode.SlidingWindow;

public class StringArrays
{
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

    public static int LongestSubstring(string s, int k)
    {
        var chars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 0, 0};

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
        }

        var isValid = true;
        var maxLen = 0;
        var start = 0;
        for (int end = 0; end < s.Length; end++)
        {
            if (chars[s[end] - 'a'] < k && chars[s[end] - 'a'] > 0)
            {
                var subStr = s.Substring(start, end - start);
                maxLen = Math.Max(maxLen, LongestSubstring(subStr, k));
                start = end + 1;
                isValid = false;
            }
        }

        if(isValid)
            return s.Length;
        else
            return Math.Max(maxLen, LongestSubstring(s.Substring(start), k));
    }

    public static int CharacterReplacement(string s, int k)
    {
        var start = 0;
        var maxLen = 0;
        var maxCount = 0;
        var chars = new int[26];

        for (int end = 0; end < s.Length; end++)
        {
            chars[s[end] - 'A']++;
            var count = chars[s[end] - 'A'];
            maxCount = Math.Max(maxCount, count);
            while (end - start - maxCount + 1 > k)
            {
                chars[s[start] - 'A']--;
                start++;
            }

            maxLen = Math.Max(maxLen, end - start + 1);
        }

        return maxLen;
    }



    public static double FindMaxAverage(int[] nums, int k)
    {
        if (nums.Length <= k)
            return (double)nums.Sum() / nums.Length;

        var maxAvg = 0.0;

        for (int end = 0; end < nums.Length - k + 1; end++)
        {
            var avg = (double)nums.Skip(end).Take(k).Sum()/k;
            maxAvg = Math.Max(maxAvg, avg);
        }

        return maxAvg;
    }




    public static double FindMaxAverageOptimized(int[] nums, int k)
    {
        var maxAvg = double.MinValue;
        var currAvg = double.MinValue;
        var sum = 0.0;

        var start = 0;

        if (nums.Length == 1)
            maxAvg = nums[0];

        for (int end = 0; end < nums.Length; end++)
        {
            sum += nums[end];

            if (end >= k - 1)
            {
                currAvg = sum/ k;
                maxAvg = Math.Max((double)maxAvg, (double)currAvg);
                sum -= nums[start];
                start++;
            }
        }

        return nums.Length == k ? currAvg : maxAvg;
    }

    public static int DivisorSubstrings(int num, int k)
    {
        var numStr = num.ToString();

        var start = 0;
        var index = k;
        var kBeauty = 0;
        for (int end = 0; end < numStr.Length; end++)
        {
            index--;
            if (index == 0)
            {
                var divisor = int.Parse(numStr.Substring(start, k));
                if(divisor != 0 && num % divisor == 0)
                    kBeauty++;
                index++;
                start++;
            }
        }

        return kBeauty;
    }

    public static int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);

        int min = int.MaxValue;
        for (int i = 0; i <= nums.Length - k; i++)
        {
            var diff = nums[i + k - 1] - nums[i];
            min = Math.Min(min, diff);
        }

        return min;
    }

    public static int MinimumRecolors(string blocks, int k)
    {
        var min = int.MaxValue;
        var start = 0;
        var recolorCount = 0;
        var index = 0;
        for (var end = 0; end < blocks.Length; end++)
        {
            if(blocks[end] == 'W')
                recolorCount++;

            index++;

            if (index == k)
            {
                min = Math.Min(min, recolorCount);
                if(blocks[start] == 'W')
                    recolorCount--;
                index--;
                start++;
            }
        }

        return min;
    }

    public static int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        var start = 0;
        var end = 0;
        var max = 0;
        var started = false;

        for (; end < nums.Length; end++)
        {
            if (nums[end] % 2 == 0 && nums[end] <= threshold && !started)
            {
                start = end;
                started = true;
            }
            else if (started && (nums[end] % 2 != (end - start) % 2 || nums[end] > threshold))
            {
                max = Math.Max(max, end - start);
                started = false;
                if (nums[end] % 2 == 0 && nums[end] <= threshold)
                {
                    start = end;
                    started = true;
                }
            }
        }
        if(started)
            max = Math.Max(max, end - start);

        return max;
    }

    public static int MaxScore(int[] cardPoints, int k)
    {
        //if (k == cardPoints.Length)
        //    return cardPoints.Sum();

        //var start = 0;
        //var end = cardPoints.Length - 1;
        //var sum = 0;

        //while (k > 0)
        //{
        //    if (cardPoints[start] > cardPoints[end])
        //    {
        //        sum+= cardPoints[start];
        //        start++;
        //    }
        //    else
        //    {
        //        sum += cardPoints[end];
        //        end--;
        //    }
        //    k--;
        //}

        //return sum;

        int total = 0;
        for (int i = 0; i < k; i++) total += cardPoints[i];
        int best = total;
        for (int i = k - 1, j = cardPoints.Length - 1; i >= 0; i--, j--)
        {
            total += cardPoints[j] - cardPoints[i];
            best = Math.Max(best, total);
        }
        return best;
    }

    //public int MaxResult(int[] nums, int k)
    //{
    //    var start = 1;
    //    var end = 0;
    //    var sum = nums[0];
    //    var max = int.MaxValue;
    //    var maxIndex = 0;
    //    while (end < nums.Length)
    //    {
    //        end++;
    //        maxIndex = nums[end] > max ? end : maxIndex;
    //        max = nums[end] > max ? nums[end] : max;
    //        if (end == k)
    //        {
    //            sum += max;
    //        }

    //    }
    //}
}
