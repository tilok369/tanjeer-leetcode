namespace LeetCode.Maths._1342;

public class ReduceNumberToZero
{
    public static void Run()
    {
        Console.WriteLine("1342. Number of Steps:");
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(14));
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(8));
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(17));
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(22));
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(1));
        Console.WriteLine(ReduceNumberToZero.NumberOfSteps(0));
    }

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
