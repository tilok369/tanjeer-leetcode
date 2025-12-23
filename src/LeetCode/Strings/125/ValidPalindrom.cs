namespace LeetCode.Strings._125;

public class ValidPalindrom
{
    public static void Run()
    {
        Console.WriteLine("125. Valid Palindrom: ");

        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindrome("race a car"));
        Console.WriteLine(IsPalindrome(""));

        Console.WriteLine(IsPalindromeTwoPointers("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindromeTwoPointers("race a car"));
        Console.WriteLine(IsPalindromeTwoPointers(""));
    }

    public static bool IsPalindrome(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
            return true;

        var sanitizedString = string.Empty;
        foreach (var c in s)
        {
            if (!(c >= 48 && c <= 57) && !(c >= 65 && c <= 90) && !(c >= 97 && c <= 122))
                continue;
            sanitizedString += c;
        }

        sanitizedString = sanitizedString.ToLower();

        for (int i = 0; i < sanitizedString.Length/2; i++)
        {
            if (sanitizedString[i] != sanitizedString[sanitizedString.Length - 1 -i])
                return false;
        }

        return true;
    }

    public static bool IsPalindromeTwoPointers(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric characters
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            // Compare characters (case-insensitive)
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
