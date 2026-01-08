using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow._1652;

public class BombDefuser
{
    public static void Run()
    {
        Console.WriteLine("1652. Defuse the bomb: ");
        Console.WriteLine(string.Join(",", Decrypt(new[] { 5, 7, 1, 4 }, 3)));
        Console.WriteLine(string.Join(",", Decrypt(new[] { 2, 4, 9, 3 }, -2)));
        Console.WriteLine(string.Join(",", Decrypt(new[] { 1, 2, 3, 4 }, 0)));
    }

    //public int[] Decrypt(int[] code, int k)
    //{
    //    var first = 1;
    //    var last = 1;
    //    var sum = 0;
    //    var length = code.Length;
    //    var decrypt = new int[length];
    //    for (int i = 0; i < length; i++)
    //    {
    //        if(k ==0)
    //            decrypt[i] = 0;
    //        else if(k > 0)
    //        {
    //            sum += code[last % (length - 1)];
    //            last++;
    //            if(last - first == 3)
    //            {
    //                decrypt[i] = sum;
    //                sum = 0;
    //            }
    //        }
    //    }
    //}

    private static int[] Decrypt(int[] code, int k)
    {
        var length = code.Length;
        var decrypt = new int[length];

        for (int i = 0; i < length; i++) 
        {
            if (k == 0)
                decrypt[i] = 0;
            else if (k > 0)
            {
                var j = 0;
                var index = i + 1;
                var sum = 0;
                while (j < k) 
                { 
                    sum += code[index % (length)];
                    index++;
                    j++;
                }
                decrypt[i] = sum;
            }
            else if (k < 0)
            {
                var j = 0;
                var index = i ==0 ?  length - 1 : i - 1;
                var sum = 0;
                var l = k * -1;
                while (j < l)
                {
                    sum += code[index % (length)];
                    index = index == 0 ? length - 1 : index - 1;
                    j++;
                }
                decrypt[i] = sum;
            }
        }

        return decrypt;
    }
}
