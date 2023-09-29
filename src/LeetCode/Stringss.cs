
using System.Text;

namespace LeetCode;

public class Stringss
{
    

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

    

    

    

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, IList<string>>();
        foreach (string str in strs)
        {
            var sorted = string.Join("", str.OrderBy(x => x));
            if (!anagrams.ContainsKey(sorted))
                anagrams.Add(sorted, new List<string> { str });
            else anagrams[sorted].Add(str);
        }

        return anagrams.Values.ToList();
    }
}
