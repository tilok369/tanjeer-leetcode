namespace LeetCode.Maths._9;

public class PalindromNumber
{
    public static void Run()
    {
        Console.WriteLine("Palindrom: ");
        Console.WriteLine(PalindromNumber.IsPalindrome(121));
        Console.WriteLine(PalindromNumber.IsPalindrome(-121));
        Console.WriteLine(PalindromNumber.IsPalindrome(10));
        Console.WriteLine(PalindromNumber.IsPalindrome(10101));
        Console.WriteLine(PalindromNumber.IsPalindrome(10101010));
        Console.WriteLine(PalindromNumber.IsPalindrome(0));
        Console.WriteLine(PalindromNumber.IsPalindrome(-10101));
    }

    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true;

        var digits = new List<int>();
        while (x > 0)
        {
            var digit = x % 10;
            digits.Add(digit);
            x = x / 10;
        }

        for (int i = 0; i < digits.Count / 2 + 1; i++)
        {
            if (digits[i] != digits[digits.Count - i - 1])
                return false;
        }

        return true;
    }
}
