using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays._349;

public class ArrayIntersection
{
    public static void Run()
    {
        Console.WriteLine("349. Intersection of Two Arrays: ");
        //Console.WriteLine(string.Join(",", Intersection(new[] { 1, 2, 2, 1 }, new[] { 2, 2 })));
        //Console.WriteLine(string.Join(",", Intersection(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 })));
        Console.WriteLine(string.Join(",", Intersection(new[] { 1 }, new[] { 1, 2 })));
    }

    private static int[] Intersection(int[] nums1, int[] nums2)
    {
        var len1 = nums1.Length;
        var len2 = nums2.Length;
        var maxLen = Math.Max(len1, len2);

        Array.Sort(nums1);
        Array.Sort(nums2);

        var index1 = 0;
        var index2 = 0;
        var element1 = -1;
        var element2 = -1;
        var intersectedList = new Dictionary<int, int>();
        while (index1 < maxLen || index2 < maxLen)
        { 
            if(index1 < len1)
                element1 = nums1[index1];
            if (index2 < len2)
                element2 = nums2[index2];

            if (element1 == element2)
            {
                if(!intersectedList.ContainsKey(element1))
                    intersectedList.Add(element1, element1);
                index1++;
                index2++;
            }    
            else if (element1 < element2)
                index1++;
            else if (element2 < element1)
                index2++;
        }

        return intersectedList.Values.ToArray();
    }
}
