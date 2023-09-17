namespace LeetCode.SlidingWindow._3;

public class LongestSubstringWithoutRepeatingCharacters
{
    public static void Run()
    {
        Console.WriteLine("Longest Substring Without Repeating Characters: ");
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("bbbbb"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("aaabbaaaababa"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abssbwertdsa"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("ab v45#$gt"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("ababcde"));
        Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("123456"));
    }

    public static int LengthOfLongestSubstring(string s)
    {

        var longestLength = 0;
        var length = 0;
        var index = 1;
        var sequence = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (sequence.ContainsKey(s[i]))
            {
                var start = sequence[s[i]];
                if (start + 1 <= sequence.Count)
                {
                    index = 1;
                    sequence = sequence.Skip(start).ToDictionary(k => k.Key, v => index++);
                    longestLength = length > longestLength ? length : longestLength;
                    length = sequence.Count;
                    //index = sequence.Count + 1;
                }
                else
                {
                    sequence = new Dictionary<char, int>();
                    longestLength = length > longestLength ? length : longestLength;
                    length = 0;
                    index = 1;
                }
            }

            sequence.Add(s[i], index++);
            length++;
        }

        longestLength = length > longestLength ? length : longestLength;

        return longestLength;
    }
}
