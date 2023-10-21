namespace LeetCode.SlidingWindow._2269;

public class KBeautyNumber
{
    public static void Run()
    {
        Console.WriteLine("2269. Find the K-Beauty of a Number: ");
        Console.WriteLine(KBeautyNumber.DivisorSubstrings(240, 2));
        Console.WriteLine(KBeautyNumber.DivisorSubstrings(430043, 2));
        Console.WriteLine(KBeautyNumber.DivisorSubstrings(50000, 3));
        Console.WriteLine(KBeautyNumber.DivisorSubstrings(500500, 3));
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
                if (divisor != 0 && num % divisor == 0)
                    kBeauty++;
                index++;
                start++;
            }
        }

        return kBeauty;
    }
}
