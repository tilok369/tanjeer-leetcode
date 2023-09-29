namespace LeetCode.Greedy._11;

public class ContainerWithMostWater
{
    public static void Run()
    {
        Console.WriteLine("11. Container With Most Water: ");
        Console.WriteLine(ContainerWithMostWater.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        Console.WriteLine(ContainerWithMostWater.MaxArea(new int[] { 1, 1 }));
    }

    public static int MaxArea(int[] height)
    {
        var maxContainer = 0;
        var start = 0;
        var end = height.Length - 1;

        while (start < end)
        {
            if (height[start] < height[end])
            {
                maxContainer = Math.Max(maxContainer, height[start] * (end - start));
                start++;
            }
            else
            {
                maxContainer = Math.Max(maxContainer, height[end] * (end - start));
                end--;
            }
        }

        return maxContainer;
    }
}
