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

    public static int LengthOfLongestSubstring2(string s)
    {
        Dictionary<char, int> hashTable = new Dictionary<char, int>();
        int start = 0;
        int length = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (hashTable.ContainsKey(s[end]))
            {
                start = Math.Max(start, hashTable[s[end]] + 1);
                hashTable[s[end]] = end;
            }
            else
            {
                hashTable.Add(s[end], end);
            }

            length = Math.Max(length, end - start + 1);
        }

        return length;
    }
}
