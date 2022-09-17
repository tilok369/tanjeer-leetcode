
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
}
