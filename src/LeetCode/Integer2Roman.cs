
using System.Text;

namespace LeetCode;
public class Integer2Roman
{
    public static string IntToRoman(int num)
    {
        var roman = new StringBuilder();
        if (num >= 1000)
            num = ProcessPlaceByPlace(num, 1000, roman);
        if (num >= 900)
            num = ProcessPlaceByPlace(num, 900, roman);
        if (num >= 500)
            num = ProcessPlaceByPlace(num, 500, roman);
        if (num >= 400) 
            num = ProcessPlaceByPlace(num, 400, roman);
        if (num >= 100)
            num = ProcessPlaceByPlace(num, 100, roman);
        if (num >= 90)
            num = ProcessPlaceByPlace(num, 90, roman);
        if (num >= 50)
            num = ProcessPlaceByPlace(num, 50, roman);
        if (num >= 40)
            num = ProcessPlaceByPlace(num, 40, roman);
        if (num >= 10)
            num = ProcessPlaceByPlace(num, 10, roman);
        if (num > 0)
            roman.Append(ProcessDigit(num));
        return roman.ToString();
    }

    private static int ProcessPlaceByPlace(int num, int place, StringBuilder roman)
    {
        var result = num / place;
        num = num % place;
        while (result > 0)
        {
            roman.Append(ProcessDigit(place));
            result--;
        }

        return num;
    }

    private static string ProcessDigit(int digit)
    {
        switch (digit)
        {
            case 1: return "I";
            case 2: return "II";
            case 3: return "III";
            case 4: return "IV";
            case 5: return "V";
            case 6: return "VI";
            case 7: return "VII";
            case 8: return "VIII";
            case 9: return "IX";
            case 10: return "X";
            case 50: return "L";
            case 100: return "C";
            case 500: return "D";
            case 1000: return "M";
            case 40: return "XL";
            case 90: return "XC";
            case 400: return "CD";
            case 900: return "CM";
            default: return "";
        }
    }
}

//class Solution
//{
//    final static int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
//    final static String[] rom = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

//    public String intToRoman(int N)
//    {
//        StringBuilder ans = new StringBuilder();
//        for (int i = 0; N > 0; i++)
//            while (N >= val[i])
//            {
//                ans.append(rom[i]);
//                N -= val[i];
//            }
//        return ans.toString();
//    }
//}