
namespace LeetCode;

public class Palindrom
{

    public static bool IsPalindrom(string sequence)
    {
        if(string.IsNullOrEmpty(sequence))
            return false;
        for (int i = 0; i < sequence.Length/2 + 1; i++)
        {
            if(sequence[i] != sequence[sequence.Length - i - 1])
                return false;
        }

        return true;
    }

    public static string LongestPalindrome(string s)
    {
        var longestSubSeq=string.Empty;
        if (s.Length == 1)
            return s;
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = 1; j <= s.Length - i; j++)
            {
                var subSeq = s.Substring(i, j);
                if (IsPalindrom(subSeq))
                {
                    longestSubSeq = subSeq.Length > longestSubSeq.Length ? subSeq : longestSubSeq;
                }
            }
        }

        return longestSubSeq;
    }

    public static string LongestPalindrome2(string s)
    {
        var len = s.Length;
        var start = 0;
        var maxLen = 1;
        bool[,] dp = new bool[len, len];

        // All substrings of lenth 1 is a palindrom
        for (int i = 0; i < len; i++)
        {
            dp[i,i] = true;
        }

        // checking substring of length 2
        for (int i = 0; i < len - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                dp[i, i+ 1] = true;
                start = i;
                maxLen = 2;
            }
        }

        // checking for length greater than 2
        for (int k = 3; k <= len; k++)
        {
            for (int i = 0; i < len - k + 1; i++)
            {
                var j = i + k - 1;
                if (dp[i + 1, j - 1] == true && s[i] == s[j])
                {
                    dp[i, j] = true;
                    if (k > maxLen)
                    {
                        start = i;
                        maxLen = k;
                    }
                }
            }
        }

        return s.Substring(start, maxLen);
    }

    public static bool IsPalindrome(int x)
    {
        if(x < 0) return false;
        if (x < 10) return true;

        var digits = new List<int>();
        while (x > 0)
        { 
            var digit = x % 10;
            digits.Add(digit);
            x = x/10;
        }

        for (int i = 0; i < digits.Count / 2 + 1; i++)
        {
            if (digits[i] != digits[digits.Count - i - 1])
                return false;
        }

        return true;
    }
}
