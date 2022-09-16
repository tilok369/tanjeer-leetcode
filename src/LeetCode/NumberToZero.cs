
namespace LeetCode;

public class NumberToZero
{
    public static int NumberOfSteps(int num)
    {
        var steps = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
                num = num / 2;
            else
                num -= 1;
            steps++;
        }

        return steps;
    }
}
