
using System.Text;

namespace LeetCode;

public class Strings
{
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

    //public int LengthOfLongestSubstring(string s)
    //{
    //    if (string.IsNullOrEmpty(s))
    //        return 0;

    //    int max = 0;
    //    string test = string.Empty;
    //    foreach (char c in s)
    //    {
    //        if (test.Contains(c))
    //            test = test.Substring(test.IndexOf(c) + 1);
    //        test = test + c;
    //        max = Math.Max(max, test.Length);
    //    }
    //    return max;
    //}

    private static Dictionary<char, List<char>> phonenumbers = new Dictionary<char, List<char>>
        {
            {'0', new List<char>()},
            {'1', new List<char>()},
            {'2', new List<char>() {'a', 'b', 'c'}},
            {'3', new List<char>() {'d', 'e', 'f'}},
            {'4', new List<char>() {'g', 'h', 'i'}},
            {'5', new List<char>() {'j', 'k', 'l'}},
            {'6', new List<char>() {'m', 'n', 'o'}},
            {'7', new List<char>() {'p', 'q', 'r', 's'}},
            {'8', new List<char>() {'t', 'u', 'v'}},
            {'9', new List<char>() {'w', 'x', 'y', 'z'}}
        };

    //private static List<string> combinations = new List<string>();

    public static IList<string> LetterCombinations(string digits)
    {
        var combinations = new List<string>();
        LetterCombinationConstructor(combinations, digits, 0, new StringBuilder());

        return combinations;
    }

    private static void LetterCombinationConstructor(List<string>  combinations, string digits, int index, StringBuilder result)
    {
        if (index >= digits.Length)
        {
            if (result.Length > 0)
            {
                combinations.Add(result.ToString());
            }
            return;
        }

        var letters = phonenumbers[digits[index]];
        foreach (var letter in letters)
        {
            result.Append(letter);
            LetterCombinationConstructor(combinations, digits, index + 1, result);
            result.Remove(result.Length - 1, 1);
        }
    }
}
