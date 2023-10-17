namespace LeetCode.HashTables._438;

public class FindAllAnagrams
{
    public static void Run()
    {
        Console.WriteLine("Find All Anagrams in a String: ");
        Console.WriteLine(String.Join(",", FindAllAnagrams.FindAnagrams("cbaebabacd", "abc")));
        Console.WriteLine(String.Join(",", FindAllAnagrams.FindAnagrams("abab", "ab")));
        Console.WriteLine(String.Join(",", FindAllAnagrams.FindAnagrams("baa", "aa")));
        Console.WriteLine(String.Join(",", FindAllAnagrams.FindAnagrams("ababababab", "aab")));
    }

    public static IList<int> FindAnagrams(string s, string p)
    {
        var anLen = p.Length;
        var start = 0;
        var anDic = new Dictionary<char, int>();
        var indexes = new List<int>();
        foreach (var c in p)
        {
            if (!anDic.ContainsKey(c))
                anDic.Add(c, 1);
            else
                anDic[c]++;
        }

        var currLen = 0;
        var found = true;
        for (var end = 0; end < s.Length; end++)
        {
            currLen++;
            if (anDic.ContainsKey(s[end]))
                anDic[s[end]]--;

            if (currLen == anLen)
            {
                if (anDic.All(a => a.Value == 0))
                    indexes.Add(start);
                if (anDic.ContainsKey(s[start]))
                    anDic[s[start]]++;
                start++;
                currLen--;
            }



        }

        return indexes;
    }
}
