
namespace LeetCode.SlidingWindow;

public class StringArrays
{

    

    



    

    

    

    

    

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
