namespace LeetCode.SlidingWindow._395;

public class LongestSubstringWithKRepeatation
{
    public static void Run()
    {
        Console.WriteLine("Longest Substring with At Least K Repeating Characters: ");
        Console.WriteLine(LongestSubstringWithKRepeatation.LongestSubstring("aaabb", 3));
        Console.WriteLine(LongestSubstringWithKRepeatation.LongestSubstring("ababbc", 2));
        Console.WriteLine(LongestSubstringWithKRepeatation.LongestSubstring("aaabbcddeababab", 3));
    }

    public static int LongestSubstring(string s, int k)
    {
        var chars = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
        }

        var isValid = true;
        var maxLen = 0;
        var start = 0;
        for (int end = 0; end < s.Length; end++)
        {
            if (chars[s[end] - 'a'] < k && chars[s[end] - 'a'] > 0)
            {
                var subStr = s.Substring(start, end - start);
                maxLen = Math.Max(maxLen, LongestSubstring(subStr, k));
                start = end + 1;
                isValid = false;
            }
        }

        if (isValid)
            return s.Length;
        else
            return Math.Max(maxLen, LongestSubstring(s.Substring(start), k));
    }
}
