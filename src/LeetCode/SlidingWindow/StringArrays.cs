
namespace LeetCode.SlidingWindow;

public class StringArrays
{

    

    



    

    

    

    

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
