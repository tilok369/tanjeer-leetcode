
namespace LeetCode.SlidingWindow;

public class HashTables
{
    

    

    

    

    

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
                if(anDic.All(a => a.Value == 0))
                    indexes.Add(start);
                if (anDic.ContainsKey(s[start]))
                    anDic[s[start]]++;
                start++;
                currLen--;
            }

            

        }

        return indexes;
    }

    public static int CountGoodSubstrings(string s)
    {
        var hashTable = new Dictionary<char, int>();
        var start = 0;
        var index = 0;
        var good = 0;
        for (int end = 0; end < s.Length; end++)
        {
            if(hashTable.ContainsKey(s[end]))
                hashTable[s[end]]++;
            else
                hashTable.Add(s[end], 1);
            index++;

            if (index == 3)
            {
                if(!hashTable.Any(i=>i.Value > 1))
                    good++;
                if(hashTable.ContainsKey(s[start]))
                    hashTable[s[start]]--;
                start++;
                index--;
            }
        }

        return good;
    }
}
