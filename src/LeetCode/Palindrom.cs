
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
}
