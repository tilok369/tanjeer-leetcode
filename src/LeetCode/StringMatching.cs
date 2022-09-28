
namespace LeetCode;

public class StringMatching
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var minLenth = strs.Min(str => str.Length);
        var commonPrefix = string.Empty;
        var matched = true;
        for (int i = 0; i < minLenth; i++)
        {
            var prefix = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (prefix != strs[j][i])
                { 
                    matched = false; 
                    break;
                }
            }
            if (!matched) return commonPrefix;

            commonPrefix += prefix;
        }

        return commonPrefix;
    }
}
