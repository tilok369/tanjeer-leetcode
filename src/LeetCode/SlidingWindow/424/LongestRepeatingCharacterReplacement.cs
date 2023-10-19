namespace LeetCode.SlidingWindow._424;

public class LongestRepeatingCharacterReplacement
{
    public static void Run()
    {
        Console.WriteLine("424. Longest Repeating Character Replacement: ");
        Console.WriteLine(LongestRepeatingCharacterReplacement.CharacterReplacement("ABAB", 2));
        Console.WriteLine(LongestRepeatingCharacterReplacement.CharacterReplacement("AABABBA", 1));
    }

    public static int CharacterReplacement(string s, int k)
    {
        var start = 0;
        var maxLen = 0;
        var maxCount = 0;
        var chars = new int[26];

        for (int end = 0; end < s.Length; end++)
        {
            chars[s[end] - 'A']++;
            var count = chars[s[end] - 'A'];
            maxCount = Math.Max(maxCount, count);
            while (end - start - maxCount + 1 > k)
            {
                chars[s[start] - 'A']--;
                start++;
            }

            maxLen = Math.Max(maxLen, end - start + 1);
        }

        return maxLen;
    }
}
