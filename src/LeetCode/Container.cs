
namespace LeetCode;

public class Container
{
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
