namespace LeetCode.Greedy._45;

public class JumpGameTwo
{
    public static void Run()
    {
        Console.WriteLine("45. Jump Game II: ");
        Console.WriteLine(JumpGameTwo.Jump2(new int[] { 2, 3, 1, 1, 4 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 2, 3, 1, 1, 4, 2, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 2 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 0, 2, 3 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 2, 3, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 3, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 1, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 0, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 1, 2, 1, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 1, 1, 1, 1 }));
        Console.WriteLine(JumpGameTwo.Jump(new int[] { 1, 2, 1, 1, 1 }));
        Console.WriteLine(JumpGameTwo.Jump2(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 0 }));
    }

    public static int Jump(int[] nums)
    {
        if (nums.Length <= 1 || nums[0] == 0)
            return 0;
        if (nums[0] >= nums.Length - 1)
            return 1;
        var steps = 0;
        var n = 0;
        var current = nums[0];
        while (n < nums.Length - 1)
        {
            var max = 0;
            var nexJump = 1;
            for (var i = 1; i <= current; i++)
            {
                if (n + i >= nums.Length - 1)
                {
                    nexJump = nums.Length;
                    break;
                }
                if (nums[n + i] >= max)
                {
                    max = nums[n + i];
                    nexJump = i;
                }
            }
            steps++;
            n += nexJump;
            if (n < nums.Length)
                current = nums[n];
            if (current == 0)
                return 0;
        }

        return steps;
    }

    public static int Jump2(int[] nums)
    {
        if (nums.Length <= 1 || nums[0] == 0)
            return 0;

        var jumps = 0;
        var max = nums[0];
        var nextMax = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (max >= nums.Length - 1)
            {
                jumps++;
                return jumps;
            }

            nextMax = Math.Max(i + nums[i], nextMax);

            if (i == max)
            {
                max = nextMax;
                jumps++;
            }
        }

        return jumps;
    }
}
