
namespace LeetCode;

public class AtoI
{
    public static int MyAtoi(string s)
    {  
        var sign = 1;
        long integer = 0;
        var i = 0;
        for (; i < s.Length; i++)
        {
            if (s[i] != ' ') break;
        }
        if (i < s.Length && (s[i] == '-' || s[i] == '+'))
        {
            if (s[i] == '-')
                sign = -1;
            i++;
        }

        for (; i < s.Length; i++)
        {
            if (s[i] < 48 || s[i] > 57)
                break;
            if (integer > int.MaxValue)
                break;
            integer = (integer * 10) + (s[i] - 48);
        }

        integer = integer * sign;

        return integer < int.MinValue 
            ? int.MinValue 
            : integer > int.MaxValue 
                ? int.MaxValue : int.Parse(integer.ToString());
    }
}

//var sign = 1;
//long integer = 0;
//var i = 0;
//        for (; i<s.Length; i++)
//        {
//            if (s[i] != ' ') break;
//        }
//        while (s[i] == '-' || s[i] == '+' || s.Length < i)
//{
//    i++;
//}

//if (i > 0 && s[i - 1] == '-')
//    sign = -1;

//for (; i < s.Length; i++)
//{
//    if (s[i] < 48 || s[i] > 57)
//        break;
//    integer = (integer * 10) + (s[i] - 48);
//}

//integer = integer * sign;

//return integer < int.MinValue
//    ? int.MinValue
//    : integer > int.MaxValue
//        ? int.MaxValue : int.Parse(integer.ToString());