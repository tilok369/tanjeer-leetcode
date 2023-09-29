
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

    

    

    //PAHNAPLSIIGYIR
    //PINALSIGYAHRPI
    public static string Convert(string s, int numRows)
    {
        if(numRows == 1)
            return s;
        var sb = new StringBuilder();
        
        for (int i = 0; i < numRows; i++)
        {
            var index = i;
            var step = 1;
            while (index < s.Length)
            {
                sb.Append(s[index]);
                if (i == 0 || i == numRows - 1)
                    index += (numRows + (numRows - 2)); // 2 edge rows
                else 
                {
                    if (step % 2 == 1)
                        index += 2 * (numRows - (i + 1));
                    else
                        index += 2 * (i);
                    step++;
                }
            }            
        }

        return sb.ToString();
    }

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
