namespace LeetCode.Backtracking._31;

public class NextPermutation
{
    public static void Run()
    {
        Console.WriteLine("Generate Parentheses: ");
        Console.WriteLine(string.Join(",", NextPermutation.NextPermutations(new int[] { 1, 2, 3 })));
        Console.WriteLine(string.Join(",", NextPermutation.NextPermutations(new int[] { 3, 2, 1 })));
        Console.WriteLine(string.Join(",", NextPermutation.NextPermutations(new int[] { 1, 1, 5 })));
    }

    /// <summary>
    /// Algo: step#1 = from right to left find the first digit (partition number) which violates the increase trend
    /// step#2 = From right to left, find the first digit which is greater than the partition number
    /// step#3 = swap partition number and change number
    /// step#4 = reverse the numbers after partition index
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int[] NextPermutations(int[] nums)
    {
        var partitionIndex = nums.Length - 2;

        while (partitionIndex >= 0)
        {
            if (nums[partitionIndex] < nums[partitionIndex + 1])
                break;
            partitionIndex--;
        }

        if (partitionIndex >= 0)
        {
            var changeNumberIndex = nums.Length - 1;

            while (changeNumberIndex > partitionIndex)
            {
                if (nums[changeNumberIndex] > nums[partitionIndex])
                    break;
                changeNumberIndex--;
            }

            Swap(ref nums[partitionIndex], ref nums[changeNumberIndex]);
        }

        Reverse(nums, partitionIndex + 1);

        return nums;
    }

    private static void Reverse(int[] nums, int index)
    {
        for (int start = index, end = nums.Length - 1; start < end; start++, end--)
        {
            Swap(ref nums[start], ref nums[end]);
        }
    }

    private static void Swap(ref int num1, ref int num2)
    {
        var temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
