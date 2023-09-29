using System.Text;

namespace LeetCode.Strings._6;

public class ZigzagConversion
{
    public static void Run()
    {
        Console.WriteLine("Zigzag Conversion: ");
        Console.WriteLine(ZigzagConversion.Convert("PAYPALISHIRING", 3));
        Console.WriteLine(ZigzagConversion.Convert("PAYPALISHIRING", 4));
        Console.WriteLine(ZigzagConversion.Convert("PAYPALISHIRING", 5));
        Console.WriteLine(ZigzagConversion.Convert("PAYPALISHIRING", 6));
        Console.WriteLine(ZigzagConversion.Convert("PAYPALISHIRING", 2));
    }

    //PAHNAPLSIIGYIR
    //PINALSIGYAHRPI
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        var sb = new StringBuilder();

        for (int i = 0; i < numRows; i++)
        {
            var index = i;
            var step = 1;
            while (index < s.Length)
            {
                sb.Append(s[index]);
                if (i == 0 || i == numRows - 1)
                    index += (numRows + (numRows - 2)); // 2 edge rows
                else
                {
                    if (step % 2 == 1)
                        index += 2 * (numRows - (i + 1));
                    else
                        index += 2 * (i);
                    step++;
                }
            }
        }

        return sb.ToString();
    }
}