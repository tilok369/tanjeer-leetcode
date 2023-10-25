namespace LeetCode.SlidingWindow._1423;

public class MaxPointsFromCards
{
    public static void Run()
    {
        Console.WriteLine("1423. Maximum Points You Can Obtain from Cards: ");
        Console.WriteLine(MaxPointsFromCards.MaxScore(new int[] { 1, 2, 3, 4, 5, 6, 1 }, 3));
        Console.WriteLine(MaxPointsFromCards.MaxScore(new int[] { 2, 2, 2 }, 2));
        Console.WriteLine(MaxPointsFromCards.MaxScore(new int[] { 9, 7, 7, 9, 7, 7, 9 }, 7));
        Console.WriteLine(MaxPointsFromCards.MaxScore(new int[] { 11, 49, 100, 20, 86, 29, 72 }, 4));
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
}
