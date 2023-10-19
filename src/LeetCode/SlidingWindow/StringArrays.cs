
namespace LeetCode.SlidingWindow;

public class StringArrays
{

    

    



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
