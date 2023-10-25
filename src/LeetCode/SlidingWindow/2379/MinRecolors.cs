namespace LeetCode.SlidingWindow._2379;

public class MinRecolors
{
    public static void Run()
    {
        Console.WriteLine("2379. Minimum Recolors to Get K Consecutive Black Blocks: ");
        Console.WriteLine(MinRecolors.MinimumRecolors("WBBWWBBWBW", 7));
        Console.WriteLine(MinRecolors.MinimumRecolors("WBWBBBW", 2));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBBBBBB", 2));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBBBBBBW", 8));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBBBBBBW", 7));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBBBBBBW", 2));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBBWBBBW", 1));
        Console.WriteLine(MinRecolors.MinimumRecolors("BBWWBBBW", 2));
    }

    public static int MinimumRecolors(string blocks, int k)
    {
        var min = int.MaxValue;
        var start = 0;
        var recolorCount = 0;
        var index = 0;
        for (var end = 0; end < blocks.Length; end++)
        {
            if (blocks[end] == 'W')
                recolorCount++;

            index++;

            if (index == k)
            {
                min = Math.Min(min, recolorCount);
                if (blocks[start] == 'W')
                    recolorCount--;
                index--;
                start++;
            }
        }

        return min;
    }
}
