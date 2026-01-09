using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTables._169;

public class MajorityElement
{
    public static void Run()
    {
        Console.WriteLine("169. Majority Element: ");
        Console.WriteLine(MajorityElementFind(new[] { 3, 2, 3 }));
        Console.WriteLine(MajorityElementFind(new[] { 2, 2, 1, 1, 1, 2, 2 }));
        Console.WriteLine(MajorityElementFindOpt(new[] { 2, 2, 1, 1, 1, 2, 2 }));
        Console.WriteLine(MajorityElementFind(new[] { 6, 6, 6, 7, 7 }));
    }

    private static int MajorityElementFind(int[] nums)
    {
        var max = int.MinValue;
        var element = int.MaxValue;
        var elementCounts = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!elementCounts.ContainsKey(nums[i]))
            {
                elementCounts.Add(nums[i], 1);
            }
            else
            {
                elementCounts[nums[i]]++;
            }
            if (elementCounts[nums[i]] > max)
            { 
                max = elementCounts[nums[i]];
                element = nums[i];
            }
        }

        return element;
    }

    private static int MajorityElementFindOpt(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}
